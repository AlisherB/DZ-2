using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task4
{
    class Program
    {
        //4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
        static void Main(string[] args)
        {
            Write("Введите количество прошедших дней : ");
            string days = ReadLine();
            double d = double.Parse(days);
            double daysSeven = 7;//Число дней в одной неделе
            double weeks = d / daysSeven;
            if(d==1)
                WriteLine(d + " день = " + weeks + " неделя");
            else if(d > 1 && d < 5)
                WriteLine(d + " дня = " + weeks + " недель");
            else if(d>4)
                WriteLine(d + " дней = " + weeks + " недель");
            ReadLine();
        }
    }
}
