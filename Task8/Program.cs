using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task8
{
    class Program
    {
        //8.	 Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
        static void Main(string[] args)
        {
            int capacity1 = 10;//объем 1 тела
            int weight1 = 9;//масса 1 
            int capacity2 = 8;//объем 2 тела
            int weight2 = 7;//масса 2
            
            int density1 = weight1 / capacity1;//плотность 1
            int density2 = weight2 / capacity2;//плотность 2

            if (density1 > density2)
            {
                Write("Первый материал имеет большую плотность");
            }
                
            else
            {
                Write("Второй материал имеет большую плотность");
            }
                
            ReadLine();
        }
    }
}
