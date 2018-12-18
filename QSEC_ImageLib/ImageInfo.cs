using System;
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
    }
}
