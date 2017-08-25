using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task7
{
    class Program
    {
        // 7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
        static void Main(string[] args)
        {
            WriteLine("Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
            Write("Введите радиус круга : ");
            string radiusCircle = ReadLine();
            int r = Int32.Parse(radiusCircle);
            Write("Введите длину стороны квадрата : ");
            string aSquare = ReadLine();
            int a = Int32.Parse(aSquare);
            double sCircle = Math.PI * Math.Pow(r, 2);
            double sSquare = Math.Pow(a, 2);
            WriteLine("Площадь круга = " + sCircle);
            WriteLine("Площадь квадрата = " + sSquare);
            if (sCircle > sSquare)
                WriteLine("Площадь круга больше");
            else if (sCircle < sSquare)
                WriteLine("Площадь квадрата больше");
            else WriteLine("Площади равны!");
            ReadLine();
        }
    }
}
