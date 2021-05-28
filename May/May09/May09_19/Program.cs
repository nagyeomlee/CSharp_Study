using System;
using System.Threading;

namespace May09_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Last_code();
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

                    case ConsoleKey.Z: // 키보드 Q를 누르면 state가 false가 되면서 무한반복 탈출
                        state = false;
                        break;
                }
            }
        }
    }
}
