using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_Практикум__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //int a, b;
            //Console.Write("a= ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {a + b}\n{a} * {b} = {a * b}");

            //Task 2
            //int a, b;
            //Console.Write("a= ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {b} + {a}\n{a} * {b} = {b} * {a}");

            //Task3 
            //int a, b, c;
            //Console.Write("a= ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c= ");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");

            //Task 4
            //double a, b;
            //Console.Write("a= ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{a} * {b} = {a * b}");

            //Task 5
            //double a, b;
            //Console.Write("a= ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{a:N3} / {b:N3} = {a / b:N3}");

            //Task6 
            //double a, b, c;
            //Console.Write("a= ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("c= ");
            //c = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"({a:N2} + {b:N2}) + {c:N2} = {a:N2} + ({b:N2} + {c:N2})");

            //Task7
            //int a, b;
            //Console.Write("a=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b=");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"a + b = {a} + {b}={a + b}\ta - b = {a} - {b}={a - b}\ta * b = {a} * {b} = {a * b}");


            //Task 8
            //int a, b;
            //Console.Write("Номинал купюры=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Колчество купюр=");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Сумма денег = {a * b:C}");

            //Task 9
            //Console.Write("радиус окружности=");
            //int radius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Длина окружности = {Math.PI * radius}\n" +
            //                  $"Площадь круга = {Math.Pow(radius,2)*Math.PI} ");

            //TaskS 10
            //Console.Write("кол-во жителей=");
            //double villagers = Convert.ToDouble(Console.ReadLine());
            //Console.Write("площадь гос-ва (км^2)=");
            //double square = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Плотность населения = {villagers / square} человек/км^2");

            //task 11
            //double a, b, c;
            //Console.Write("katet 1=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("katet 2=");
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"периметр = {a + b + c}");

            //Task 12
            //double a, b, diagonal;
            //Console.Write("Side 1=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("side 2=");
            //b = Convert.ToInt32(Console.ReadLine());
            //diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"Диагональ = {diagonal:N3} \nПериметр = {(a +b)*2}");

            //Task 13
            //int x1, x2, y1, y2;
            //Console.Write("x1=");
            //x1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("y1=");
            //y1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("x2=");
            //x2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("y2=");
            //y2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)):N3}");

            //Task 14
            //Console.Write("Стоимость 1 кг конфет: ");
            //double costOfSweats = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Стоимость 1 кг печенья: ");
            //double costOfCookies = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Стоимость 1 кг яблок: ");
            //double costOfApples = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Сколько купили конфет (в кг): ");
            //double Sweats = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Сколько купили печенья (в кг): ");
            //double Cookies = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Сколько купили яблок (в кг): ");
            //double Apples = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Стоимость всей покупки: {(costOfSweats * Sweats) + (costOfCookies * Cookies) + (costOfApples * Apples):C}");

            //Task 15
            //Console.Write("Введите двухзначное число: ");
            //int twoDigitNumber = Convert.ToInt32(Console.ReadLine());
            //int numberOfTens = twoDigitNumber / 10;
            //int numberOfUnits = twoDigitNumber % 10;
            //Console.WriteLine($"Число десятков: {numberOfTens}\n" +
            //    $"Число единиц: {numberOfUnits}\n" +
            //    $"Сумма цифр: {numberOfTens + numberOfUnits}\n" +
            //    $"Произведение цифр: {numberOfTens * numberOfUnits}");

            Console.ReadKey();
        }
    }
}
