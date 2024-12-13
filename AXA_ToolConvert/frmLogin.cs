using DocProBM.BM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AXA_ToolConvert
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region validate 
        /// <summary>
        /// Kiểm tra định dạng tài khoản mật khẩu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public bool Validate(string id, string pin)
        {
            //kiếm tra tài khoản mật khẩu trống
            //nếu sai hiển thị thông báo
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Tài khoản không được để trống!");
                return false;
            }
            //kiểm tra mật khẩu trống
            //nếu sai hiển thị thông báo
            if (string.IsNullOrEmpty(pin))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return false;
            }
            //kiểm tra tài khoản có đúng định dạng số
            //sai định dạng gửi thông báo
            if (!Int32.TryParse(id, out int result))
            {
                MessageBox.Show("Tài khoản không đúng định dạng!");
                return false;
            }
            //kiếm tra mật khẩu có đúng định dạng số
            //sai định dạng gửi thông báo
            if (!Int32.TryParse(pin, out int result2))
            {
                MessageBox.Show("Mật khẩu không đúng định dạng!");
                return false;
            }
            return true;
        }
        #endregion
        private void btn_login_Click(object sender, EventArgs e)
        {
            //Kiểm tra định dạng của tài khoản và mật khẩu
            if (!Validate(txtID.Text, txtPin.Text))
            {
                return;
            }
            // BMChecker.isTsValid check tài khoản mật khẩu 
            //kiểm tra sai thì hiện ra thông báo
            if (!BMChecker.IsTsValid(int.Parse(txtID.Text), txtPin.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                return;
            }
            // ẩn form đăng nhập
            this.Visible = false;
            // mở form chính
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
