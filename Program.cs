namespace Vocabulary_trainer
{
    internal static class Program
    {
        private readonly static string pathOfFile = "D:\\Files\\Great Structured Knowledge\\Eng lng\\Dictionary.txt";
        public readonly static Random random = new Random();
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        private static int NumberOfLines()
        {
            StreamReader streamReader = new StreamReader(pathOfFile);
            int counter = 0;
            string? line = streamReader.ReadLine();
            while (line != null)
            {
                line = streamReader.ReadLine();
                counter++;
            }
            return counter;
        }
        public static string[] ArrayOfEngWords()
        {
            StreamReader streamReader = new StreamReader(pathOfFile);
            string?[] lines = new string[NumberOfLines()];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = streamReader.ReadLine();
            }
            return lines;
        }
    }
}