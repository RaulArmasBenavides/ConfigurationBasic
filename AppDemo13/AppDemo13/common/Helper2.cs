using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace AppDemo13.Common
{
    public class Helper2
    {
     
        #region Images


        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public static Image BitmapToBytes(byte[] image, ImageFormat pFormat)
        {
            var imageObject = new Bitmap(new MemoryStream(image));
            var stream = new MemoryStream();
            imageObject.Save(stream, pFormat);
            return new Bitmap(stream);
        }

        //public static Image StreamToBitmap(string path)
        //{
        //    new System.Drawing.Bitmap(System.Drawing.Image.FromFile(Server.MapPath("~/view/vacantapredeal/vacantapredeal.jpg")));
        //    var imageObject = new Bitmap(new MemoryStream(File.ReadAllBytes(path)));
        //    var _stream = new MemoryStream();
        //    imageObject.Save(_stream, ImageFormat.Jpeg);
        //    return new Bitmap(_stream);
        //}


        public static void CreatingImageTest(string path)
        {
            var bitmap = new Bitmap(900, 900);

            //for (var x = 0; x < bitmap.Width; x++)
            //{
            //    for (var y = 0; y < bitmap.Height; y++)
            //    {
            //        bitmap.SetPixel(x, y, Color.BlueViolet);
            //    }
            //}
           
            RectangleF rectf = new RectangleF(70, 90, 900, 900);

            Graphics g = Graphics.FromImage(bitmap);

            string ArticleText = "Holaestan estoooo\n"+
                                "Esto es una pruebitaa.\n";

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(ArticleText, new Font("Tahoma", 12), Brushes.Black, rectf);
          
            g.Flush();
            bitmap.Save(path);
            //bitmap.Save("m.bmp");
        }


        #endregion
    }
}
