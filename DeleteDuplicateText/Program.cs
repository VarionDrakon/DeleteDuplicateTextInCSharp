class MainClass
{
    public static void Main()
    {
        using (TextWriter outputWriter = new StreamWriter("output.txt"))
        {
            string? fileName;
            string? textForReplace;
            int i = 0;

            Console.WriteLine("Enter your name file. Specify either a relative path to the file (For example C:/filename.txt ) or place the file in the same directory as the file being run.");
            fileName = Console.ReadLine();
            Console.WriteLine("Enter your text for deleting in files");
            textForReplace = Console.ReadLine();
            try
            {
                foreach (var item in File.ReadAllLines(fileName))
                {
                    var replaceText = item.Replace(textForReplace, "");
                    Console.WriteLine("number string: " + i++ + " Content: " + replaceText);
                    outputWriter.WriteLine(replaceText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message.ToString());
            }

        }
    }
}