// p.114 6번, 7번, 8번

using System;

namespace May09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inch.Inch_cal();
            Killogram.Killo_cal();
            Circle.Circle_round_cal();
            Circle.Circle_area_cal();
        }
    }

    public class Inch
    {
        public static void Inch_cal()
        {
            Console.Write("inch입력 : ");
            string inch = Console.ReadLine();
            int value = int.Parse(inch);
            double result = value * 2.54;
            Console.WriteLine(inch + "inch를 cm로 바꾸면 " + result + "cm이다.\n");
        }
    }

    public class Killogram
    {
        public static void Killo_cal()
        {
            Console.Write("kg입력 : ");
            string kilo = Console.ReadLine();
            int value = int.Parse(kilo);
            double result = value * 2.20462262;
            Console.WriteLine(kilo + "kg을 pound로 바꾸면 " + result + "pound이다.\n");
        }
    }

    public class Circle
    {
        public static double PI = 3.14;
        public static void Circle_round_cal()
        {
            Console.Write("반지름 입력 : ");
            string line = Console.ReadLine();
            int value = int.Parse(line);
            double result = 2 * PI * value;
            Console.WriteLine("반지름 " + line + "인 원의 둘레는 " + result + "이다.\n");
        }
        public static void Circle_area_cal()
        {
            Console.Write("반지름 입력 : ");
            string area = Console.ReadLine();
            int value = int.Parse(area);
            double result = PI * value * value;
            Console.WriteLine("반지름 " + area + "인 원의 둘레는 " + result + "이다.");
        }
    }
}
