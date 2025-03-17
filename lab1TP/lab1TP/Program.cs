namespace lab1TP
{

    public class Logic
    {
        public static string IsTriangle(double a, double b, double c)
        {

            string outMessage1 = "";
            if (a + b > c && a + c > b && b + c > a)
            {
                outMessage1 = "A triangle exists.";
            }
            else { 
                outMessage1 = "A triangle doesn`t exist.";
            }
            return outMessage1;
        }

        public static string IsRightTriangle(double a, double b, double c)
        {

            string outMessage2 = "";
            if (Math.Abs(a * a + b * b - c * c) < 0.0001 || Math.Abs(a * a + c * c - b * b) < 0.0001 || Math.Abs(b * b + c * c - a * a) < 0.0001)
            {
                outMessage2 = "The triangle has 90-angle.";
            }
            else
            {
                outMessage2 = "The triangle doesn`t have 90-angle.";
            }
            return outMessage2;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            //взаимодействие с юзером
            Console.WriteLine("Enter number a:");
            double a = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter number b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number c:");
            double c = double.Parse(Console.ReadLine());
            //конец взаимодействия

            //ЛОГИКА
            string outMessage1 = Logic.IsTriangle(a, b, c);

            
        
            //ВЗАИМОЙДЕСТВИЕ
            Console.WriteLine(outMessage1);
            if (outMessage1 == "A triangle exists.")
            {
                string outMessage2 = Logic.IsRightTriangle(a, b, c);
                Console.WriteLine(outMessage2);

            }
        }
    }
}
