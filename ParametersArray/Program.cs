using System;

namespace ParametersArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 88, 91, 76, 64, 60, 99, 74 };
           Console.WriteLine(GetAverage(studentsGrades));

            foreach(int student in studentsGrades)
            {
                if(student > 89)
                {
                    Console.WriteLine("A");
                } 
                else if (student > 79)
                {
                    Console.WriteLine("B");
                }
                else if (student > 69)
                {
                    Console.WriteLine("C");
                }
                else if (student > 59)
                {
                    Console.WriteLine("D");
                } 
                else
                {
                    Console.WriteLine("F"); 
                }
                
            }
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double) sum / size;

            return average;
        }
    }
}
