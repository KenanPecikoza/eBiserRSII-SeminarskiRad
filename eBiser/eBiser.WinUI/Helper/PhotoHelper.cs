using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBiser.WinUi.Helper
{
    public class PhotoHelper
    {
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn==null)
            {
                return null;
            }
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image ByteArrayToImage(byte[] array)
        {
            if (array.Count()==0)
            {
                return null;
            }
            MemoryStream stream = new MemoryStream(array);
            return Image.FromStream(stream);
        }


    }
}
