using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Обязательная задача*. Создать метод для вычисления объема и площади поверхности куба по длине его ребра. 
             */
            //Ввод исходных данных
            Console.WriteLine("Введите длину стороны куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double V, S;
            //Вывзов метода
            CalcCube(a, out V, out S);
            //Вывод результата
            Console.WriteLine("Объем куба составляет {0} мм3",V);          
            Console.WriteLine("Площадь куба составляет {0} мм3",S);
            Console.ReadKey();
        }
        //Заводим метод вычисления площади повершности и объема куба
        static void CalcCube(double a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6 * (Math.Pow(a, 2));
        }
    }
}
