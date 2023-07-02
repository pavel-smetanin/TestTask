namespace ShtafunTestTask
{
    internal class ImgParam
    {
        public int Right { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }

        //Увеличить все параметры на 1
        public void IncrementParams()
        {
            Right++;
            Left++;
            Top++;
            Bottom++;
        }
        //Сгенерировать рандомные параметры
        public void RandomParams()
        {
            int min = 1;
            int max = 20;
            Random rnd = new Random();
            Right = rnd.Next(min, max);
            Left = rnd.Next(min, max);
            Top = rnd.Next(min, max);
            Bottom = rnd.Next(min, max);
        }
    }
}
