using System.Drawing;
//THIS using thing was so VS stopped complaining :sob:
using Image = System.Drawing.Image;

//I may have borked this up, BUTTTT it works!
//I think it only reads from the resources in dll?
namespace LemonCore.Libs
{
    public class image
    {
        //These are local varibles that are private to this class. (i think)
        private Image _image;
        private Rectangle _renderArea;

        //this kinda just for making new images (this should be like newImage or something)
        public Image RenderImage(System.Drawing.Image resourceImage, Rectangle area)
        {
            _image = resourceImage;
            _renderArea = area;
            return _image;
        }

        //THE actual rendering of the image to the window!
        public void Render(Graphics g)
        {
            if (_image != null)
            {
                g.DrawImage(_image, _renderArea);
            }
        }
        //bye bye image? i think that this is right?
        public void DestroyImage(Image image)
        {
            image?.Dispose();
        }
    }
}
