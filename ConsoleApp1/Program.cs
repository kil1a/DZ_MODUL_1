using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 1

            //int a;
            //Console.WriteLine("Введите число от 1 до 100: ");
            //a = Int32.Parse(Console.ReadLine());
            //if (a < 0 || a > 100) Console.WriteLine("ОШИБКА!!! введите число от 1 до 100: ");
            //else
            //{
            //    if (a % 3 == 0) Console.WriteLine("Fizz");
            //    if (a % 5 == 0) Console.WriteLine("Buzz");
            //    if ((a % 3 == 0) && (a / 5 == 0)) Console.WriteLine("Fizz Buzz");
            //    if (!((a % 3 == 0) || (a % 5 == 0))) Console.WriteLine("не делится" + a);
            //}

            //------------------------------------------------------------------------------------------------------------------------------------------//
            //ЗАДАНИЕ 2

            //int a, b;
            //double l;
            //a = Int32.Parse(Console.ReadLine());
            //b = Int32.Parse(Console.ReadLine());
            //l = (a / 100) * b;
            //Console.WriteLine(a);

            //------------------------------------------------------------------------------------------------------------------------------------------//
            //ЗАДАНИЕ 3

            //int p, o, i, u;
            //p = Int32.Parse(Console.ReadLine());
            //o = Int32.Parse(Console.ReadLine());
            //i = Int32.Parse(Console.ReadLine());
            //u = Int32.Parse(Console.ReadLine());
            //p *= 1000;
            //o *= 100;
            //i *= 10;
            //p = p + o + i + u;
            //Console.WriteLine(p);

            //------------------------------------------------------------------------------------------------------------------------------------------//
            //ЗАДАНИЕ 4

            //int f, k, j, h, g, s, r;
            //Console.WriteLine("введите 6ти значное число");
            //f = Int32.Parse(Console.ReadLine());
            //k = f / 100000;
            //f = f % 100000;
            //j = (f / 10000) * 10;
            //f = f % 10000;
            //h = (f / 1000) * 100;
            //f = f % 1000;
            //g = (f / 100) * 1000;
            //f = f % 100;
            //s = (f / 10) * 10000;
            //f = f % 10;
            //r = f * 100000;
            //Console.WriteLine(r + s + g + h + j + k);

            //------------------------------------------------------------------------------------------------------------------------------------------//
            //ЗАДАНИЕ 5

            //int day, month, year;
            //Console.Write("введите дату:\nДень:");
            //day = Int32.Parse(Console.ReadLine());
            //Console.Write("Месяц: ");
            //month = Int32.Parse(Console.ReadLine());
            //Console.Write("Год: ");
            //year = Int32.Parse(Console.ReadLine());

            //if ((month <= 0) && (month > 12) && (day > 31)&&(day<=0)) Console.Write("ОШИБКА!!! введите верную дату:");
            //else
            //{
            //    if((month>=1)&&(month<=3)) Console.Write("Зима, ");
            //    if ((month > 3) && (month <= 6)) Console.Write("Весна, ");
            //    if ((month > 6) && (month <= 9)) Console.Write("Лето, ");
            //    if ((month > 9) && (month <= 12)) Console.Write("Осень, ");

            //    if ((day == 2) || (day==9)||(day==16)||(day==23)||(day==30)) Console.Write("Понедельник\n");
            //    if ((day == 3) || (day == 10) || (day == 17) || (day == 24) || (day == 31)) Console.Write("Вторник\n");
            //    if ((day == 4) || (day == 11) || (day == 18) || (day == 25) ) Console.Write("Среда\n");
            //    if ((day == 5) || (day == 12) || (day == 19) || (day == 26) ) Console.Write("Четверг\n");
            //    if ((day == 6) || (day == 13) || (day == 20) || (day == 27) ) Console.Write("Пятница\n");
            //    if ((day == 7) || (day == 14) || (day == 21) || (day == 28)) Console.Write("Субота\n");
            //    if ((day == 8) || (day == 15) || (day == 22) || (day == 29)) Console.Write("Воскресенье\n");
            //}

            //------------------------------------------------------------------------------------------------------------------------------------------//
            //ЗАДАНИЕ 6

            //int temp;
            //double c, f;
            //Console.Write("Перевод\n1 - из C в F\n2 - из F в C\n");
            //temp = Int32.Parse(Console.ReadLine());

            //if(temp == 1) {
            //    Console.Write("Введите температуру по C: ");
            //    c = Int32.Parse(Console.ReadLine());
            //    f = c * 33.8;
            //    Console.Write("Ваша температура по фаренгейту ровна: " + f);
            //}
            //else
            //{
            //    Console.Write("Введите температуру по F: ");
            //    f = Int32.Parse(Console.ReadLine());
            //    c = f / 33.8;
            //    Console.Write("Ваша температура по цельсию ровна: " + c);
            //}

            //------------------------------------------------------------------------------------------------------------------------------------------//
            //ЗАДАНИЕ 7

            //Console.WriteLine("Введите два числа:");
            //int num1 = Int32.Parse(Console.ReadLine());
            //int num2 = Int32.Parse(Console.ReadLine());

            //if (num1 > num2){
            //    int temp;
            //    temp = num1;
            //    num1 = num2;
            //    num2 = temp;
            //}

            //for (int i = num1; i <= num2; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");
            //}








        }
    }
}
