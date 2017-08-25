using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task6
{
    class Program
    {
        //  6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
                //a.А или В; 
                //b.А и В; 
                //c.В или С.

        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool c = false;
            WriteLine("a = true; b = false; c = false");
            bool result = (a || b);
            WriteLine("a) a || b = " + result);
            result = (a && b);
            WriteLine("b) a && b = " + result);
            result = (b || c);
            WriteLine("c) b || c = " + result);
            ReadLine();
        }
    }
}
