using System;

namespace May09_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Add_result();
            //Char_print();
            //Reverse_for();
            //Reverse_char();
            Print_foreach();
        }

        public static void While1()
        {
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray[i]);
                i++;
            }
        }

        public static void Do_while1()
        {
            string input;
            do
            {
                Console.Write("입력(exit 또는 q를 입력하면 종료) : ");
                input = Console.ReadLine();
            } while (input != "exit" && input != "q");
        }

        public static void Add_result()
        {
            int i, result = 0;
            for (i = 0; i <= 10; i++)
            {
                result += i;
            }
            Console.WriteLine("10까지 누적 값은 : " + result);
            Console.WriteLine("마지막 i의 값은 : " + i);
        }

        public static void Char_print()
        {
            for (int i = '가'; i <= '힣'; i++)
            {
                Console.Write((char)i);
            }
        }

        public static void Reverse_for()
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        public static void Reverse_char()
        {
            char[] charArray = {'h', 'e', 'l', 'l', 'o'};

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(charArray[i]);
            }
        }

        public static void Print_foreach()
        {
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
