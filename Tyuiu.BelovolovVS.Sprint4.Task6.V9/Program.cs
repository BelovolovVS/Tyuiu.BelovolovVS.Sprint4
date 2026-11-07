using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BelovolovVS.Sprint4.Task6.V9.Lib;

namespace Tyuiu.BelovolovVS.Sprint4.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Беловолов В. С. | Группа: ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Беловолов В. С. | Группа: ПИНб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Красный\", \"Оранжевый\", \"Желтый\",    *");
            Console.WriteLine("* \"Зеленый\", \"Синий\", \"Индиго\", \"Фиолетовый\"] используя класс Array*");
            Console.WriteLine("* подсчитайте количество элементов, длина которых меньше 7.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var colors = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= colors.Length - 1; i++)
            {
                Console.WriteLine(colors[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых меньше 7:");

            int nums = ds.Calculate(colors);
            Console.WriteLine(nums);

            Console.ReadKey();
        }
    }
}