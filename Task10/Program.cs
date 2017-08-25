using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task10
{
    class Program
    {
//        Напечатать "столбиком": 
//              a.все целые числа от 20 до 35;
//              b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
//              c.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a< 50);
//              d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).
        static void Main(string[] args)
        {
            int menu = -1;
            do
            {
                if (menu == -1)
                {
                    WriteLine("1 - Все целые числа от 20 до 35");
                    WriteLine("2 - Квадраты всех целых чисел от 10 до b");
                    WriteLine("3 - Третьи степени всех целых чисел от a до 50");
                    WriteLine("4 - Все целые числа от a до b");
                    WriteLine("0 - Выход");
                    Write("\nВведите команду - ");
                    string menuStr = ReadLine();
                    menu = Int32.Parse(menuStr);
                }
                else if (menu == 1)
                {
                    Clear();
                    WriteLine("Все целые числа от 20 до 35");
                    for (int i = 20; i <= 35; i++)
                    {
                        WriteLine(i);
                    }
                    ReadLine();
                    Clear();
                    menu = -1;
                }
                else if (menu == 2)
                {
                    Clear();
                    WriteLine("Квадраты всех целых чисел от 10 до b");
                    Write("\nВведите значение b (b > 10) = ");
                    string b = ReadLine();
                    int bEnd = Int32.Parse(b);
                    if(bEnd <= 10)
                    {
                        while(bEnd <= 10)
                        {
                            WriteLine("Неверное конечное значение!");
                            ReadLine();
                            Clear();
                            WriteLine("Квадраты всех целых чисел от 10 до b");
                            Write("\nВведите значение b (b > 10) = ");
                            b = ReadLine();
                            bEnd = Int32.Parse(b);
                        }
                    }
                    for(int i = 10; i <= bEnd; i++)
                    {
                        WriteLine("\n" + Math.Pow(i, 2));
                    }
                    ReadLine();
                    Clear();
                    menu = -1;
                }
                else if (menu == 3)
                {
                    int aBegin;
                    int bEnd = 50;
                    Clear();
                    WriteLine("Третьи степени всех целых чисел от a до 50 (a < 50)");
                    Write("\nВведите значение a = ");
                    string a = ReadLine();
                    aBegin = Int32.Parse(a);
                    if (aBegin >= bEnd)
                    {
                        while(aBegin >= bEnd)
                        {
                            WriteLine("Неверное начальное значение!");
                            ReadLine();
                            Clear();
                            WriteLine("Третьи степени всех целых чисел от a до 50 (a < 50)");
                            Write("\nВведите значение a = ");
                            a = ReadLine();
                            aBegin = Int32.Parse(a);
                        }
                    }
                    for (int i = aBegin; i < bEnd; i++)
                    {
                        WriteLine("\n" + Math.Pow(i, 3));
                    }
                    ReadLine();
                    Clear();
                    menu = -1;
                }
                else if (menu == 4)
                {
                    Clear();
                    WriteLine("Все целые числа от a до b");
                    Write("\nНачальное значение А = ");
                    string a = ReadLine();
                    int aBegin = Int32.Parse(a);

                    Write("Конечное значение B = ");
                    string b = ReadLine();
                    int bEnd = Int32.Parse(b);
                    if (aBegin >= bEnd)
                    {
                        while(aBegin >= bEnd)
                        {
                            WriteLine("Введены неверные значения!");
                            ReadLine();
                            Clear();
                            Write("Начальное значение А = ");
                            a = ReadLine();
                            aBegin = Int32.Parse(a);

                            Write("Конечное значение B = ");
                            b = ReadLine();
                            bEnd = Int32.Parse(b);
                        } 
                    }
                    for (int i = aBegin; i <= bEnd; i++)
                    {
                        WriteLine(i);
                    }
                    ReadLine();
                    Clear();
                    menu = -1;
                }
                else
                {
                    WriteLine("Неверный пункт меню!");
                    ReadLine();
                    Clear();
                    menu = -1;
                }
                    
            } while (menu != 0);
        }
    }
}
