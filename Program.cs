using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int noe = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
            int nowd = int.Parse(Console.ReadLine());

            int[][] salaries = new int[noe][];

            for (int i = 0; i < noe; i++)
            {
                salaries[i] = new int[noe];
                Console.WriteLine($"Enter salary for Employee {i + 1}:");
                for (int j = 0; j < nowd; j++)
                {
                    Console.Write($"Enter salary for Day {j + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nWeekly Salary:");

            for (int i = 0; i < noe; i++)
            {
                int totalSalary = 0;
                Console.Write($"Employee {i + 1}: ");
                for (int j = 0; j < nowd; j++)
                {
                    Console.Write($"{salaries[i][j]} ");
                    totalSalary += salaries[i][j];
                }
                Console.WriteLine($"Total Salary: {totalSalary}");
            }

        }
    }
}
