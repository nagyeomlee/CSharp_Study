using System;

namespace May09_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //star01();
            //star02();
            Break_keyword();
        }

        public static void Star01()
        {
            Console.Write("값을 입력하세요. : ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < i+1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }

        }

        public static void Star02()
        {
            Console.Write("값을 입력하세요. : ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = input; j > i+1; j--)
                    Console.Write(' ');
                for (int j = 0; j < i+1; j++)
                   Console.Write('*');
                Console.Write('\n');
            }
        }

        public static void Break_keyword()
        {
            while(true)
            {
                Console.Write("숫자를 입력해주세요. (짝수를 입력하면 프로그램이 끝남) : ");
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                    break;
            }    
        }
    }
}
