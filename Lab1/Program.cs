using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int x;
        double a, z, e;

        Console.Write("Введіть значення e: ");
        e = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення x: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть значення a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть значення z: ");
        z = Convert.ToInt32(Console.ReadLine());


        double y = Math.Pow(e, (z - 1) / (a - 2)) + Math.Sqrt(Math.Pow(x, 2) - Math.Pow(a, 2) - Math.Pow(z, 2));

        Console.WriteLine("Результат обчислення виразу: " + y);
        Console.WriteLine();
    }
}


//using System;
//using System.Text;

//class Program
//{
//    static int SumDel(int x)
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        int res = 0;
//        for (int i = 1; i <= x / 2; i++)
//            if (x % i == 0) res += i;
//        return res;
//    }
//    static void Main(string[] args)
//    {
//        int n = 200, m = 300;
//        for (int i = n; i <= m; i++)
//        {
//            if (SumDel(SumDel(i)) == i)
//                Console.WriteLine(i + " та " + SumDel(i) + " дружні числа");
//        }
//        Console.WriteLine();
//    }
//}



//using System;
//using System.Text;

//namespace CsHelp
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = Encoding.UTF8; 

//            Console.WriteLine("Введіть s та t: ");
//            double s = Convert.ToDouble(Console.ReadLine());
//            double t = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Результат виразу: g(1.2, s)+ g(t, s)- g(2s-1, st) :");
//            double result = g(1.2, s) + g(t, s) - g(2 * s - 1, s * t);
//            Console.WriteLine(result);

//        }
//        public static double g(double a, double b)
//        {
//            return (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) + 2 * a * b + 3 * Math.Pow(b, 2) + 4);
//        }
//    }
//}