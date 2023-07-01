namespace ShtafunTestTask
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Row row = new Row();
                //Здесь можно ввести путь к изображениям
                string img1 = "../../../Images/1.jpg";
                string img2 = "../../../Images/2.jpg";
                string img3 = "../../../Images/3.jpg";
                string img4 = "../../../Images/4.jpg";
                string resultImg = "../../../Images/test.png";
                row.ImageAdd(img1);
                row.ImageAdd(img2);
                row.ImageAdd(img3);
                row.ImageAdd(img4);
                Console.Write("Input the width of result image: ");
                string width = Console.ReadLine();
                var result = row.GetStoryboardImage(Int32.Parse(width));
                result.Save(resultImg);
                Console.WriteLine($"The result image is saved in: {resultImg}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


