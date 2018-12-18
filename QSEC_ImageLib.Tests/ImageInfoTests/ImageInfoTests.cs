using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace QSEC_ImageLib.Tests.ImageInfoTests
{
    public class ImageInfoTests
    {
        [Fact]
        public void CanInitClass()
        {
            var imageInfo = new ImageInfo();
            Assert.NotNull(imageInfo);
        }

        [Fact]
        public void NoImage_Throws_ArgumentNullException()
        {
            var imageInfo = new ImageInfo();
            Assert.Throws<ArgumentNullException>(() => imageInfo.GetPixelCount(null));
        }

        [Fact]
        public void GivenImage_Returns_PixelCount()
        {
            var imageInfo = new ImageInfo();
            Assert.Equal(100, imageInfo.GetPixelCount(new Image { Width = 10, Height = 10 }));
            Assert.Equal(1000000, imageInfo.GetPixelCount(new Image { Width = 1000, Height = 1000 }));
        }
    }
}
