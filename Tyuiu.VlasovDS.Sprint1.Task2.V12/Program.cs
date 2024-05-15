using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VlasovDS.Sprint1.Task2.V12.Lib;

namespace Tyuiu.VlasovDS.Sprint1.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Власов Д. С. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил: Власов Дмитрий Сергеевич | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, находит объем параллелепипеда.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            int y;
            int z;

            Console.WriteLine("Введите высоту параллелепипеда:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину параллелепипеда:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину параллелепипеда:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объем параллелепипеда = " + ds.CalculateParallelepipedVolume(x, y, z));
            Console.ReadKey();



        }
    }
}
