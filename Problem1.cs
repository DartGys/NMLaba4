using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLaba4
{
    class Problem1
    {
        public Problem1()
        {
            Calculation();
        }
        private double G1(double x, double y)
        {
            double tan = (x * y - 1) - (Math.Pow(x * y - 1, 3)) / 3; // Ряд Тейлора для приближеного обчилсення тангенсу
            return Math.Sqrt(tan + 1);
        }
        private double G2(double x, double y)
        {
            return Math.Sqrt((1-Math.Pow(x, 2))/2);
        }
        private void Calculation()
        {
            double x = 0;
            double y = 0;

            double epsilon = 1e-6; 
            int max_iterations = 1000; 

            int i;
            for (i = 0; i < max_iterations; i++)
            {
                double x_new = G1(x, y);
                double y_new = G2(x, y);

                Console.WriteLine($"Iteration {i}: x= {x_new}; \ty= {y_new}");
                if (Math.Abs(x_new - x) < epsilon && Math.Abs(y_new - y) < epsilon)
                {
                    break;
                }

                x = x_new;
                y = y_new;
            }

            if (i < max_iterations - 1)
            {
                Console.WriteLine("\nSolution:");
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
            }
            else
            {
                Console.WriteLine("Не вдалося знайти розв'язок протягом заданої кількості ітерацій.");
            }
        }
    }

}

