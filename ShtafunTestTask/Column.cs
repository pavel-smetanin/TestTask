using System;
using System.Drawing;

namespace ShtafunTestTask
{
    internal class Column : BaseElement
    {
        public List<Row> Rows { get; private set; }
        public Column() : base()
        {
            Rows = new List<Row>();
        }
        public void RowAdd(Row row)
        {
            Rows.Add(row);
            var stbImg = row.GetStoryboardImage();
            Images.Add(stbImg);
        }
        public override Bitmap GetStoryboardImage()
        {
            int newWidth = Images.Min(x => x.Width);
            int sumHeight = 0;
            foreach (var i in Images)
            {
                float propCoef = Tools.GetPropCoef(i.Height, i.Width);
                int newHeight = Tools.GetPropHeight(newWidth, propCoef);
                sumHeight += newHeight;
            }
            Bitmap bitmap = new Bitmap(newWidth, sumHeight);
            Graphics graphics = Graphics.FromImage(bitmap);
            int localHeight = 0;
            foreach (var i in Images)
            {
                float propCoef = Tools.GetPropCoef(i.Height, i.Width);
                int newHeight = Tools.GetPropHeight(newWidth, propCoef);
                graphics.DrawImage(i, 0, localHeight, newWidth, newHeight);
                localHeight += newHeight;
            }
            StoryborardedImg = bitmap;
            return bitmap;
        }
    }
}
