using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tsk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Обязательная задача*. 
             * Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
             * (создать метод для вычисления  площади  треугольника по длинам его сторон).  
             * Для решения задачи можно использовать формулу Герона
             * S=SQRT(p*(p-x)*(p-y)*(p-z) , где x, y, z – стороны треугольника, p – полупериметр.
             */
            //Ввод исходных данных для первого треугольника
            Console.WriteLine("Введите три стороны треугольника 1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            //Вычисление площади первого треугольника через вызов метода
            double S1 = CalcS(x1, y1, z1);
            //Ввод исходных данных для второго треугольника
            Console.WriteLine("Введите три стороны треугольника 2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            // Вычисление площади первого треугольника через вызов метода
            double S2 = CalcS(x2, y2, z2);
            //Вывод значений площадей трегугольников
            Console.WriteLine("Площадь треугольника 1 {0,00:.00}", S1);
            Console.WriteLine("Площадь треугольника 2 {0,00:.00}", S2);
            //Сравнение площадей треугольников
            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (S1<S2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else if (S1==S2)
            {
                Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadKey();

        }
        // Задаем метод вычисления площади треугольника по формуле Герона
        static double CalcS(double x, double y, double z/*, out double p, out double S*/)
        {
            double p = (((double)x) + z + y) / 2;// Вычисляем полупериметр
            double S = Math.Sqrt(((double)p) * (p - x) * (p - y) * (p - z));//вычисляем площадь
            return S;//возвращаем значение площади по запросу
        }
    }

}
