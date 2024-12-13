using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AXA_ToolConvert.Utils;

namespace AXA_ToolConvert
{
    public partial class FrmMain : Form
    {
        #region biến
        private string PathName;
        private List<string> listFile = new List<string>();
        private string rootDestination;
        private int success;
        private int fail;
        private int totalNumber;
        #endregion
        #region khởi tạo
        private void KhoiTao()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            pb_loading.Visible = false;
            txt_pathName.ReadOnly = true;
            txt_pathName.BackColor = Color.White;
            rtb_Log.ReadOnly = true;
            rtb_Log.BackColor = Color.White;
            rtb_Log.HideSelection = false;
            btn_convert.Enabled = false;
            pb_loading.Value = 0;
            pb_loading.Maximum = 100;
            pb_loading.Minimum = 0;

        }
        #endregion
        #region logic
        /// <summary>
        /// Ghi message ra màn hình log 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status"></param>
        private void WriteLog(string message, int status = 0)
        {
            //status =0 thống báo mặc định
            if (status == 0)
            {
                rtb_Log.SelectionColor = Color.Black;
            }
            // status =1 thông báo thành công
            if (status == 1)
            {
                rtb_Log.SelectionColor = Color.Green;
            }
            //status = 2 thông báo lỗi
            if (status == 2)
            {
                rtb_Log.SelectionColor = Color.Red;
            }
            if (string.IsNullOrEmpty(rtb_Log.Text))
            {
                rtb_Log.SelectedText += message;
            }
            else rtb_Log.SelectedText += "\n" + message;
        }
        //dùng hàm của thư viện đọc ảnh xử lý được file ảnh tiff lớn ko bị out memory
        private void convertToPDF2(string file, string destination)
        {
            Invoke(new Action(() =>
            {
                WriteLog(file + " : Đang xử lý!", 1);
            }));
            ///sử dụng từ thư viện file là đường dẫn thư mục cfn destination là đường dẫn đích
            TiffToPdfConverter.converter2(file, destination);
            Invoke(new Action(() =>
            {
                WriteLog(destination + " : Thành công!", 1);
                success++;
                lbl_success.Text = "Thành công : " + success.ToString();
            }));

        }
        private string DestinationPath(string root, string fileName)
        {
            var destination = "";
            //lấy tên file pdf
            var outPutFileName = Path.GetFileNameWithoutExtension(fileName) + ".pdf";
            var directory = new DirectoryInfo(fileName).Parent.FullName;
            //lấy ra cấu trúc thư mục
            //giả sử đường dẫn thư mục chứa file là /xyz/abc/data và thư mục gốc là /xyz
            //filestructure trả về abc/data
            var fileStructure = directory.Substring(PathName.Length + 1);
            destination = Path.Combine(root, fileStructure);
            //kiểm tra thư tồn tại nếu ko tồn tại thì tạo thư mục
            if (!Directory.Exists(destination))
            {
                DirectoryInfo di = Directory.CreateDirectory(destination);
            }
            destination = Path.Combine(destination, outPutFileName);

            return destination;
        }
        #endregion
        public FrmMain()
        {
            InitializeComponent();
            KhoiTao();
        }
        private void btn_fileInput_Click(object sender, EventArgs e)
        {
            try
            {
                //reset lại list file khi chọn lại file
                listFile.Clear();
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    PathName = fbd.SelectedPath;
                    txt_pathName.Text = fbd.SelectedPath;
                    Task.Run(() =>
                    {
                        string[] allfiles = Directory.GetFiles(PathName, "*.tif*", SearchOption.AllDirectories);//chọn tất cả các file từ thư mục cha
                        if (allfiles == null)
                        {
                            WriteLog("Thư mục gốc không tồn tại file *.tiff nào !", 2);
                            return;
                        }
                        string message = "";

                        foreach (var file in allfiles)
                        {
                            message += "\n " + file;
                            listFile?.Add(file);
                        }
                        WriteLog("Thư mục bao gồm :" + message);
                        //thể hiện số file ra giao diện
                        lbl_totalNumber.Text = "Tổng số file : " + listFile.Count().ToString();
                        totalNumber = listFile.Count();
                        btn_convert.Enabled = true;
                    });

                }
            }
            catch (Exception ex)
            {
                listFile = null;
                WriteLog("lỗi : " + ex.Message, 2);
            }
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_output.Text))
            {
                WriteLog("Thư mục gốc không tồn tại file *.tiff nào !", 2);
                return;
            }
            //kiếm tra danh sách file đã có hay chưa
            if (listFile == null)
            {
                WriteLog("Thư mục gốc không tồn tại file *.tiff nào !", 2);
                return;
            }
            //kiểm tra người dùng đã nhập thư mục gốc hay chưa
            if (string.IsNullOrEmpty(txt_pathName.Text))
            {
                WriteLog("Bạn chưa chọn thư mục gốc !", 2);
                return;
            }
            //hiển thị loading 
            pb_loading.Visible = true;
            WriteLog("Bắt đầu chuyển đổi tiff sang pdf !");
            // bắt đầu 1 tiến trình mới 
            pb_loading.Value = 0;
            Task.Run(() =>
            {
                foreach (var file in listFile)
                {
                    var destination = DestinationPath(rootDestination, file);
                    try
                    {
                        convertToPDF2(file, destination);
                        Invoke(new Action(() =>
                        {
                            int checkTotal = pb_loading.Value + (int)Math.Ceiling(((float)(100) / totalNumber));
                            if (checkTotal > pb_loading.Maximum)
                            {
                                pb_loading.Value = 100;
                            }
                            else pb_loading.Value += (int)Math.Ceiling(((float)(100) / totalNumber));
                        }));
                    }
                    catch (Exception ex)
                    {
                        fail++;

                        Invoke(new Action(() =>
                        {
                            lbl_fail.Text = "Thất bại : " + fail;
                            WriteLog(destination + " : " + ex.Message, 2);
                        }));
                    }
                }

                Invoke(new Action(() =>
                {
                    pb_loading.Value = 100;
                    Task.Delay(100);

                    MessageBox.Show("Chuyển đổi hoàn thành!");
                    pb_loading.Visible = false;
                }));

            });

        }

        private void btn_DeleteLog_Click(object sender, EventArgs e)
        {
            rtb_Log.Text = "";
        }


        private void btn_fileoutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rootDestination = fbd.SelectedPath;
                txt_output.Text = fbd.SelectedPath;
            }

        }

    }
}
