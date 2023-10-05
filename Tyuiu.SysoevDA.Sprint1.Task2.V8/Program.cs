using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SysoevDA.Sprint1.Task2.V8.Lib;

namespace Tyuiu.SysoevDA.Sprint1.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Сысоев Д.А | ПКТБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Сысоев Данил Алексеевич | ПКТБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* расчеты: Известны длины стороны прямоугольника. Вычислить периметр      *");
            Console.WriteLine("* прямоугольника.                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Периметр прямоугольника = {ds.CalculatePerimetr(x, y)}");
            Console.ReadLine();
        }
    }
}
