using System;
using System.Drawing;
using System.Linq;


namespace ShtafunTestTask
{
    internal class Row : BaseElement
    {
        public List<Column> Columns { get; private set; }
        public Row() : base()
        {
            Columns = new List<Column>();
        }
        public void ColumnAdd(Column column)
        {
            Columns.Add(column);
            var stbImg = column.GetStoryboardImage();
            Images.Add(stbImg);
        }
        public override Bitmap GetStoryboardImage()
        { 
            int newHeight = Images.Min(x => x.Height);
            int sumWidth = 0;
            foreach(var i in Images)
            {
                float propCoef = Tools.GetPropCoef(i.Height, i.Width);
                int newWidth = Tools.GetPropWidth(newHeight, propCoef);
                sumWidth += newWidth;
            }
            Bitmap bitmap = new Bitmap(sumWidth, newHeight);
            Graphics graphics = Graphics.FromImage(bitmap);
            int localWidth = 0;

            foreach (var i in Images)
            {
                float propCoef = Tools.GetPropCoef(i.Height, i.Width);
                int newWidth = Tools.GetPropWidth(newHeight, propCoef);
                graphics.DrawImage(i, localWidth, 0, newWidth, newHeight);
                localWidth += newWidth;
            }
            StoryborardedImg = bitmap;
            return bitmap;
        }
    }
}
