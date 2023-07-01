using System;
using System.Drawing;


namespace ShtafunTestTask
{
    internal class Row
    {
        public List<Bitmap> Images { get; private set; } 
        public Row()
        {
            Images = new List<Bitmap>();
        }
        public void ImageAdd(string filename)
        {
            Bitmap image = (Bitmap)Bitmap.FromFile(filename);
            Images.Add(image);
        }

        public Bitmap GetStoryboardImage(int widthImage)
        {
            //Переменная для поиска минимума
            int heightImage = Images[0].Height; 
            //Переменная сумматор
            int sumWidth = 0;
            //Нахождение суммы ширин и поиск минимальной высоты изображений
            //Высота результирующего изображения будет равна минимальной высоте 
            foreach (var i in Images)
            {
                sumWidth += i.Width;
                if (i.Height < heightImage)
                    heightImage = i.Height;
            }
            //Коэффициент увеличения(уменьшения) длин с учетом введенной результирующей ширины
            float delta = widthImage / (float)sumWidth;
            heightImage = (int)Math.Ceiling(heightImage * delta);
            //Результирующее изображение
            Bitmap bitmap = new Bitmap(widthImage, heightImage);
            Graphics graphics = Graphics.FromImage(bitmap);
            int localWidth = 0;
            //Перебор всех изображений
            foreach (var i in Images)
            {
                //Коэффициент пропорциональности изображения
                float propCoef = (float)i.Height / i.Width;
                //Новая ширина
                int newWidth = (int)Math.Ceiling(heightImage / propCoef);
                //Размещения измененного изображения в результирующем
                graphics.DrawImage(i, localWidth, 0, newWidth, heightImage);
                localWidth += newWidth;
            }
            return bitmap;
        }

    }
}
