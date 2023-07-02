namespace ShtafunTestTask
{
    class Program
    {
        public static void Main()
        {
            try
            {
                //Здесь можно ввести путь к изображениям
                string img1 = "../../../Images/1.jpg";
                string img2 = "../../../Images/2.jpg";
                string img3 = "../../../Images/3.jpg";
                string img4 = "../../../Images/4.jpg";
                string img5 = "../../../Images/5.jpg";
                string img6 = "../../../Images/6.jpg";
                string img7 = "../../../Images/7.jpg";
                string img8 = "../../../Images/8.jpg";
                string resultStr = "../../../Images/testTree.png";

                Row root = new Row();
                Column col1 = new Column();
                Column col2 = new Column();
                Column col3 = new Column();
                Row row1 = new Row();

                root.ImageAdd(img1);
                root.ImageAdd(img2);

                col1.ImageAdd(img5);
                col1.ImageAdd(img6);

                col2.ImageAdd(img3);
                row1.ImageAdd(img4);

                col3.ImageAdd(img7);
                col3.ImageAdd(img8);

                row1.ColumnAdd(col3);
                col2.RowAdd(row1);

                root.ColumnAdd(col1);
                root.ColumnAdd(col2);

                ImagesTree imgTree = new ImagesTree();
                imgTree.InitTree(root);

                Console.Write("Input the width of result image: ");
                string width = Console.ReadLine();
                var result = imgTree.GetTreeStoryboard(Int32.Parse(width));
                result.Save(resultStr);
                Console.WriteLine($"The result image is saved in: {resultStr}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


