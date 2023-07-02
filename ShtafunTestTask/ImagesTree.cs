using System;
using System.Drawing;

namespace ShtafunTestTask
{
    internal class ImagesTree
    {
        public Row RootRow { get; private set; }
        public ImagesTree() 
        {
            RootRow = new Row();
        }
        public void InitTree(Row row)
        {
            RootRow = row;
        }
        public Bitmap GetTreeStoryboard(int newWidth)
        {
            Bitmap treeImg = RootRow.GetStoryboardImage();
            float propCoef = Tools.GetPropCoef(treeImg.Height, treeImg.Width);
            int newHeight = Tools.GetPropHeight(newWidth, propCoef);
            Bitmap resulImg = new Bitmap(newWidth, newHeight);
            Graphics graphics = Graphics.FromImage(resulImg);
            graphics.DrawImage(treeImg, 0, 0, newWidth, newHeight);
            return resulImg;
        }
    }
}
