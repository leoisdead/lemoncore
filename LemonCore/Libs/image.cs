using System.Drawing;
using Image = System.Drawing.Image;

namespace LemonCore.Libs
{
    public class image
    {
        private Image _image;
        private Rectangle _renderArea;

        public Image RenderImage(System.Drawing.Image resourceImage, Rectangle area)
        {
            _image = resourceImage;
            _renderArea = area;
            return _image;
        }
        public void Render(Graphics g)
        {
            if (_image != null)
            {
                g.DrawImage(_image, _renderArea);
            }
        }
        public void DestroyImage(Image image)
        {
            image?.Dispose();
        }
    }
}
