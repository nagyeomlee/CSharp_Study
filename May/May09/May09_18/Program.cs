using System;

namespace May09_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Break_keyword();
        }
        public static void Break_keyword()
        {
            while (true)
            {
                Console.Write("숫자를 입력해주세요. (짝수를 입력하면 프로그램이 끝남) : ");
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                    break;
            }
        }
    }
}
