using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task3
{
    class Program
    {
        //3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        static void Main(string[] args)
        {
            Write("Введите расстояние в см. : ");
            string santimetr = ReadLine();
            int sm = Int32.Parse(santimetr);
            int smHundred = 100;//1 м = 100 см;
            double m = sm / smHundred;
            WriteLine(sm + " см = " + m + " м");
            ReadLine();
        }
    }
}
