namespace Лаб1ТПСтроки
{
    public class Logic
    { 
        public static double Count(string sentence)
        {
            int letterCount = 0;
            int totalCharsWithoutSpaces = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                char currentChar = sentence[i];

                if (char.IsLetter(currentChar))
                {
                    letterCount++;
                    totalCharsWithoutSpaces++;
                }
                else if (!char.IsWhiteSpace(currentChar))
                {
                    totalCharsWithoutSpaces++;
                }
            }

            if (totalCharsWithoutSpaces > 0)
            {
                return (double)letterCount / totalCharsWithoutSpaces * 100; //приведение типов для (double)letterCount
            }
            else
            {
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            double percentage = Logic.Count(sentence);

            Console.WriteLine($"Percentage of letters: {percentage:F2}%");
            Console.ReadKey();
        }
    }
}