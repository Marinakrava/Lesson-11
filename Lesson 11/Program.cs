using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение");
            double k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе значение");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Результат: ");
            Linear_equation linear = new Linear_equation(k,b);

            Console.WriteLine(linear.Root());
            Console.ReadKey();  

        }
    }
}
