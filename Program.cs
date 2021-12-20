using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение. Введите первое число");

            string S1 = Console.ReadLine();
            int a = int.Parse(S1);

            Console.WriteLine("Введите второе число");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);

            int c = a + b;

            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + c.ToString());

            Console.WriteLine("Вычитание. Введите первое число");

            string S3 = Console.ReadLine();
            int av = int.Parse(S3);

            Console.WriteLine("Введите второе число");
            string S4 = Console.ReadLine();
            int bv = int.Parse(S4);

            int cv = av - bv;

            Console.WriteLine(av.ToString() + " - " + bv.ToString() + " = " + cv.ToString());

            Console.WriteLine("Деление. Введите первое число");

            string S5 = Console.ReadLine();
            int avc = int.Parse(S5);

            Console.WriteLine("Введите второе число");
            string S6 = Console.ReadLine();
            int bvc = int.Parse(S6);

            int cvc = avc / bvc;

            Console.WriteLine(avc.ToString() + " / " + bvc.ToString() + " = " + cvc.ToString());



            Console.WriteLine("Степень. Введите число");

            string SV1 = Console.ReadLine();
            int AV = int.Parse(SV1);


            int stepen = 2;
            Console.WriteLine("В квадрате = " + Math.Pow(AV, stepen));

            Console.ReadLine();
        }
    }
}