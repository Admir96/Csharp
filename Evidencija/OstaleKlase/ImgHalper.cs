using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencija.OstaleKlase
{
   public class ImgHalper
    {
        public static byte[] FromImageToByte(Image image)
        {
            if (image != null)
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
            return null;
       }
        public static Image FromByteToImage(byte[] image)
        {
            if (image != null)
            {
                MemoryStream ms = new MemoryStream(image);
                return Image.FromStream(ms);
            }
            return null;
        }
    }
}
