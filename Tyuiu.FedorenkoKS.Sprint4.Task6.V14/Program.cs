using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FedorenkoKS.Sprint4.Task6.V14.Lib;

namespace Tyuiu.FedorenkoKS.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Федоренко К.С. | ИСПб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Класс Array                                                          *");
            Console.WriteLine("* Задание #6                                                                 *");
            Console.WriteLine("* Вариант #14                                                                *");
            Console.WriteLine("* Выполнил: Федоренко Кирилл Сергеевич | ИСПб-23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан строковый массив данных [Январь, Февраль, Март, Апрель, Май,           *");
            Console.WriteLine("* Июнь, Июль], используя класс Array, выведите элементы массива, длина       *");
            Console.WriteLine("* которых больше 3 символа.                                                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:                                                           *");
            Console.WriteLine("******************************************************************************");

            var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

            for (int i = 0; i <= month.Length - 1; i++)
            {
                Console.WriteLine(month[i]);
            }

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* КОНЕЧНЫЙ МАССИВ:                                                           *");
            Console.WriteLine("******************************************************************************");

            month = ds.Calculate(month);

            for (int i = 0; i <= month.Length - 1; i++)
            {
                Console.Write($"{month[i]} \t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}