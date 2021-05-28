using System;

namespace May09_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ex01();
        }

        public static void Ex01()
        {
            Console.Write("이름을 입력하시오 : ");
            string str = Console.ReadLine();

            if (str.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }

    }
}
