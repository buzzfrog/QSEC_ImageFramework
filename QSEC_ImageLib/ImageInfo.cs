using System;
using System.Drawing;
using System.IO;
using QSEC_ImageLib.Interfaces;

namespace QSEC_ImageLib
{
    public class ImageInfo : IImageInfo
    {
        public int GetPixelCount(Image image)
        {
            if (image == null)
                throw new ArgumentNullException("Image can't be null");

            return image.Width * image.Height;
        }

        public int GetPixelCount(string path)
        {
            if (path == string.Empty)
                throw new ArgumentOutOfRangeException("path", "path can't be empty");

            try
            {
                var image = new Bitmap(path, false);

                return image.Width * image.Height;
            }
            catch(ArgumentException ex)
            {
                throw new FileNotFoundException();
            }

        }

    }
}
