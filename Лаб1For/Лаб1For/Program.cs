using System;
using System.Collections.Generic;
using System.Linq;

namespace Лаб1For
{
    public class Logic
    {
        public static string AnalyzeGrades(List<int> grades)
        {
            int fives = 0;
            int fours = 0;
            int threes = 0;
            int twos = 0;

            foreach (int grade in grades)
            {
                switch (grade)
                {
                    case 5:
                        fives++;
                        break;
                    case 4:
                        fours++;
                        break;
                    case 3:
                        threes++;
                        break;
                    case 2:
                        twos++;
                        break;
                }
            }

            return $"\nNumber of fives: {fives} \nNumber of fours: {fours} \nNumber of threes: {threes} \nNumber of twos: {twos}";
        }

        public static List<int> GetGradesFromUser()
        {
            List<int> grades = new List<int>();
            bool validInput = false;

            while (!validInput)
            { 

                Console.WriteLine("Enter grades separated by spaces (2-5):");
                string input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("No input. Please try again.");
                    continue; 
                }

                string[] gradeStrings = input.Split(' ');
                validInput = true;

                foreach (string gradeString in gradeStrings)
                {
                    if (int.TryParse(gradeString, out int grade))//TryParse позволяет "обрабатывать исключения". Он выведет 0, если будет несоответсвие типу.
                    {
                        if (grade >= 2 && grade <= 5)
                        {
                            grades.Add(grade);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid grade: {gradeString}. Please enter grades between 2 and 5.");
                            validInput = false;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input: {gradeString}. Please enter integer grades between 2 and 5.");
                        validInput = false;
                        break;
                    }
                }
            }
            return grades;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = Logic.GetGradesFromUser();
            string result = Logic.AnalyzeGrades(grades);
            Console.WriteLine($"Summary of student progress: {result}");
        }
    }
}