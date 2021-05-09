using System;

namespace May09_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ex01();
            date();
            ampm();
        }

        public static void ex01()
        {
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다.\n");
            }

            if (input % 2 == 1)
            {
                Console.WriteLine("홀수입니다.\n");

            }
        }

        public static void date()
        {
            Console.WriteLine(DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + " "
                + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\n");
        }

        public static void ampm()
        {
            if (DateTime.Now.Hour > 12)
            {
                Console.WriteLine("지금은 오후 {0}입니다.\n", DateTime.Now.Hour);
            }
            else
            {
                Console.WriteLine("지금은 오전 {0}시 입니다.\n", DateTime.Now.Hour);
            }
        }
    }
}
