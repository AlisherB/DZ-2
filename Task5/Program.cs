using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task5
{
    class Program
    {
//        5. Дано двузначное число. Найти:
//                  a.число десятков в нем;
//                  b.число единиц в нем;
//                  c.сумму его цифр;
//                  d.произведение его цифр

        static void Main(string[] args)
        {
            Write("Введите 2-значное число : ");
            string doubleNum = ReadLine();
            int numX = Int32.Parse(doubleNum);
            do
            {
                if (numX > 9 && numX < 100)
                {
                    int numTen = numX / 10;
                    int numOne = numX % 10;
                    WriteLine("В числе " + numX + " : ");
                    WriteLine("\t" + numTen + " десятков");
                    WriteLine("\t" + numOne + " единиц");
                    int sum = numOne + numTen;
                    int proiz = numOne * numTen;
                    WriteLine("Сумма " + numOne + " и " + numTen + " = " + sum);
                    WriteLine("Произведение " + numOne + " и " + numTen + " = " + proiz);
                    break;
                }
                else
                {
                    Write("Введите 2-значное число : ");
                    doubleNum = ReadLine();
                    numX = Int32.Parse(doubleNum);
                }
            } while (numX != 0);
            ReadLine();
        }
    }
}
