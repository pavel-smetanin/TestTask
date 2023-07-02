using System;
using System.Drawing;


namespace ShtafunTestTask
{
    internal abstract class BaseElement
    {
        public List<Bitmap> Images { get; protected set; }
        protected Bitmap StoryborardedImg { get; set; }
        public BaseElement() 
        {
            Images = new List<Bitmap>();
        }
        public void ImageAdd(string filename)
        {
            Bitmap image = (Bitmap)Bitmap.FromFile(filename);
            Images.Add(image);
        }
        public abstract Bitmap GetStoryboardImage();
    }
}
