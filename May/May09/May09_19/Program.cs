using System;
using System.Threading;

namespace May09_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Continue_print();
            //Upper_Lower();
            //Split_exam();
            //Trim_exam();
            //Join_array();
            //Move_method();
            //Thread_sleep();
            //Move_snail();
            Last_code();
        }

        public static void Continue_print()
        {
            Console.WriteLine("0부터 입력한 수까지의 범위 내에서 홀수만 출력합니다 : ");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);

            }
        }

        public static void Upper_Lower()
        {
            Console.Write("영문 문자열을 입력해주세요. : ");
            string str = Console.ReadLine();

            Console.WriteLine("입력한 문자열의 대문자화 : " + str.ToUpper());
            Console.WriteLine("입력한 문자열의 소문자화 : " + str.ToLower());
            Console.WriteLine("입력한 원 문자열 : " + str);
        }

        public static void Split_exam()
        {
            Console.Write("단어 다섯가지를 입력해주세요. (단어사이에는 공백이 존재해야합니다) : ");
            string str = Console.ReadLine();
            string[] strs = str.Split(new char[] { ' ' , ','});
            // string[] strs = str.Split(' ');

            foreach (var item in strs)
            {
                Console.WriteLine(item);
            }
        }

        public static void Trim_exam()
        {
            string str = Console.ReadLine();
            Console.WriteLine("**" + str.Trim() + "**");
            // Trim, TrimStart(), TrimEnd()
        }

        public static void Join_array()
        {
            string[] array = { "감자", "고구마", "호박", "가지", "토마토" };
            var new_array = string.Join(" ", array);
            Console.WriteLine(new_array);
            Console.WriteLine(new_array.GetType());
        }

        public static void Move_method()
        {
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(10, 10);
            Console.Write("메서드 호출 후");
        }

        public static void Thread_sleep()
        {
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }

        public static void Move_snail()
        {
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);
                x++;
            }
        }

        public static void Last_code()
        {
            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;

                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;

                    case ConsoleKey.Q: // 키보드 Q를 누르면 state가 false가 되면서 무한반복 탈출
                        state = false;
                        break;
                }
            }
        }
    }
}
