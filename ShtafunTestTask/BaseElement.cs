using System.Drawing;

namespace ShtafunTestTask
{
    internal abstract class BaseElement
    {
        public List<Bitmap> Images { get; protected set; }
        public BaseElement() 
        {
            Images = new List<Bitmap>();
        }
        public void ImageAdd(string filename, ImgParam param)
        {
            Bitmap image = (Bitmap)Bitmap.FromFile(filename);
            image = ParamAdd(image, param);
            Images.Add(image);
        }
        private Bitmap ParamAdd(Bitmap image, ImgParam param)
        {
            int newWidth = image.Width + param.Right + param.Left;
            int newHeight = image.Height + param.Top + param.Bottom;
            Bitmap bitmap = new Bitmap(newWidth, newHeight);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, param.Left, param.Top, image.Width, image.Height);
            return bitmap;
        }
        public abstract Bitmap GetStoryboardImage();
    }
}
