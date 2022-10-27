using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    struct Linear_equation
    {
        double k;
        double b;

        public Linear_equation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            double x = -b / k;
            if (k == 0 && b == 0)
                return "Всегда будет 0";

            double x1 = -b / k;
            if (k == 0 && b != 0)
                return "Корней нет";
            
            double x2 = -b / k;
            return $"{x2}";
         
        }
    }

}

