using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace AddApplication.Utils
{
    class FileImage
    {

        public static Bitmap ConvertToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);

            }
            return bitmap;
        }

    }
}
