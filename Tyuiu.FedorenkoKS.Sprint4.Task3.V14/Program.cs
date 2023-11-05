using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FedorenkoKS.Sprint4.Task3.V14.Lib;
namespace Tyuiu.FedorenkoKS.Sprint4.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] mtrx = new int[5, 5] { { 3, 2, 3, 3, 5 },
                                          { 2, 3, 3, 7, 3 },
                                          { 7, 5, 2, 7, 3 },
                                          { 4, 2, 7, 5, 2 },
                                          { 3, 5, 4, 2, 6 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Федоренко К.С. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Двумерные массивы. (статический ввод)                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Федоренко Кирилл Сергеевич | ИСПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7.                          *");
            Console.WriteLine("* Найдите максимальный элемент в четвертой строке массива.                *");
            Console.WriteLine("*  3, 2, 3, 3, 5,                                                         *");
            Console.WriteLine("*  2, 3, 3, 7, 3,                                                         *");
            Console.WriteLine("*  7, 5, 2, 7, 3,                                                         *");
            Console.WriteLine("*  4, 2, 7, 5, 2,                                                         *");
            Console.WriteLine("*  3, 5, 4, 2, 6,                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Максимальный элемент четвертой строки = " + res);
            Console.ReadKey();

        }
    }
}