using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, y1, y2, y3, y4;
            Console.WriteLine("Введите значение координат для первой точки: ");
            Console.Write("Введите координаты х для первой точки: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y для первой точки: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координат для второй точки: ");
            Console.Write("Введите координату x для второй точки: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y для второй точки: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координат для третьей точки: ");
            Console.Write("Введите координату x для третьей точки: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y для третьей точки: ");
            y3 = Convert.ToInt32(Console.ReadLine());

            y4 = x4 = 0;
            if (x1 == x2)
            {
                if (y3 == y2)
                {
                    y4 = y1;
                    x4 = x3;
                }
                else if (y3 == y1)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else Console.WriteLine("Не параллельны");
            }
            else if (x2 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x1;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x1;
                    y4 = y2;
                }
                else Console.WriteLine("Не параллельны");
            }
            else if (x1 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x2;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x2;
                    y4 = y2;
                }
                else Console.WriteLine("Не параллельны");
            }
            else Console.WriteLine("Не параллельны");


            Console.WriteLine(x1 + "\t" + y1);
            Console.WriteLine(x2 + "\t" + y2);
            Console.WriteLine(x3 + "\t" + y3);
            Console.WriteLine(x4 + "\t" + y4);
            Console.ReadKey();
        }
    }
}
