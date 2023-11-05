using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FedorenkoKS.Sprint4.Task0.V13.Lib;

namespace Tyuiu.FedorenkoKS.Sprint4.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Федоренко К.С. | ИСПб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                *");
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #13                                                                *");
            Console.WriteLine("* Выполнил: Федоренко Кирилл Сергеевич | ИСПб 23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный            *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных      *");
            Console.WriteLine("* элементов массива.  {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}                         *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Сумма четных элементов массива = " + ds.GetSumEvenArrEl(numsArray));

            Console.ReadKey();
        }
    }
}