using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task9
{
    class Program
    {
        //9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и 
        //     напряжение на каждом из них.По какому участку протекает меньший ток?
        static void Main(string[] args)
        {
            Write("Введите напряжение : ");
            string u = ReadLine();
            int uOne = Int32.Parse(u);
            Write("Введите сопротивление : ");
            string r = ReadLine();
            int rOne = Int32.Parse(r);
            double iOne;
            double iTwo;
            if (rOne == 0)
            {
                Write("Введите сопротивление снова: ");
                r = ReadLine();
                rOne = Int32.Parse(r);
            }
                iOne = uOne / rOne;
                WriteLine("Сила тока первого участка эл. цепи = " + iOne);
            
            Write("Введите напряжение : ");
            string u2 = ReadLine();
            int uTwo = Int32.Parse(u2);
            Write("Введите сопротивление : ");
            string r2 = ReadLine();
            int rTwo = Int32.Parse(r2);
            if (rTwo == 0)
            {
                Write("Введите сопротивление снова: ");
                r2 = ReadLine();
                rTwo = Int32.Parse(r2);
            }
                iTwo = uTwo / rTwo;
                WriteLine("Сила тока второго участка эл. цепи = " + iTwo);

            if (iOne < iTwo)
                WriteLine("\nПо первому участку эл.цепи протекает меньший ток!");
            else if (iOne > iTwo)
                WriteLine("\nПо второму участку эл.цепи протекает меньший ток!");
            else
                WriteLine("Силы тока равны!");
            ReadLine();
        }
    }
}
