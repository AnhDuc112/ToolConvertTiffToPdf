using System.Drawing;
using System.Drawing.Imaging;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System;
using ImageMagick;

namespace AXA_ToolConvert.Utils
{
    public class TiffToPdfConverter
    {
        /// <summary>
        /// Chuyển đổi file TIFF sang file PDF
        /// </summary>
        /// <param name="tiffPath">Đường dẫn đến file TIFF đầu vào</param>
        /// <param name="pdfPath">Đường dẫn để lưu file PDF đầu ra</param>
        public static void ConvertTiffToPdf(string tiffPath, string pdfPath)
        {
            if (!File.Exists(tiffPath))
            {

                return;
            }

            // Tạo tài liệu PDF
            PdfDocument pdfDocument = new PdfDocument();

            // Đọc file TIFF
            using (Image tiffImage = Image.FromFile(tiffPath))
            {
                int frameCount = tiffImage.GetFrameCount(FrameDimension.Page); // Số trang trong TIFF


                for (int i = 0; i < frameCount; i++)
                {
                    // Chọn trang hiện tại
                    tiffImage.SelectActiveFrame(FrameDimension.Page, i);

                    // Tạo trang PDF mới
                    PdfPage page = pdfDocument.AddPage();
                    page.Width = tiffImage.Width * 72 / tiffImage.HorizontalResolution;
                    page.Height = tiffImage.Height * 72 / tiffImage.VerticalResolution;

                    // Lưu trang TIFF hiện tại vào MemoryStream
                    using (var ms = new MemoryStream())
                    {
                        Bitmap bitmap = new Bitmap(tiffImage);
                        bitmap.Save(ms, ImageFormat.Png); // Lưu thành PNG
                        ms.Position = 0; // Đặt vị trí đầu luồng

                        // Tạo XImage từ MemoryStream
                        XImage xImage = XImage.FromStream(ms);

                        // Vẽ hình ảnh lên trang PDF
                        using (XGraphics gfx = XGraphics.FromPdfPage(page))
                        {
                            gfx.DrawImage(xImage, 0, 0, page.Width, page.Height);
                        }
                    }
                }
            }

            // Lưu file PDF
            pdfDocument.Save(pdfPath);

        }
        /// <summary>
        /// chuyển đổi file qua tiff qua file pdf
        /// </summary>
        /// <param name="tiffPath"></param>
        /// <param name="pdfPath"></param>
        public static void converter2(string tiffPath, string pdfPath)
        {
            if (!System.IO.File.Exists(tiffPath))
            {

                return;
            }

            using (var images = new MagickImageCollection())
            {
                // Đọc file TIFF
                images.Read(tiffPath);



                foreach (var image in images)
                {
                    // Thêm từng trang vào PDF
                    image.Format = MagickFormat.Pdf;
                }

                // Gộp các trang thành một PDF
                images.Write(pdfPath);


            }
        }
    }
}

