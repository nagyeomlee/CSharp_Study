using System;

namespace May09_16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Switch_case();
            //exam1();
            //exam2();
            //exam3();
            //season();
            change_switch();
        }

        public static void Switch_case()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위");
                    break;

                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래");
                    break;

                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽");
                    break;

                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽");
                    break;

                default:
                    Console.WriteLine("다른키를 눌렀습니다");
                    break;
            }
        }

        // p.140 2번문제
        public static void exam1()
        {
            int x, y;
            Console.Write("x 값 : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y 값 : ");
            y = int.Parse(Console.ReadLine());

            if (x > 4)
            {
                if (y > 2)
                {
                    Console.WriteLine(x * y);
                }
            }
            else
            {
                Console.WriteLine();
            }

        }

        // p.141 3번 문제
        public static void exam2()
        {
            int x;
            Console.Write("x 값 입력하시오 : ");
            x = int.Parse(Console.ReadLine());

            if (x > 10 && x < 20)
            {
                Console.WriteLine("조건에 맞습니다.");
            }
        }

        // p.141 4번문제
        public static void exam3()
        {
            int year, result;
            Console.Write("태어난 년도를 입력하시오. : ");
            year = int.Parse(Console.ReadLine());

            result = year % 12;

            switch(result)
            {
                case 0:
                    Console.WriteLine("원숭이띠");
                    break;

                case 1:
                    Console.WriteLine("닭띠");
                    break;

                case 2:
                    Console.WriteLine("개띠");
                    break;

                case 3:
                    Console.WriteLine("돼지띠");
                    break;

                case 4:
                    Console.WriteLine("쥐띠");
                    break;

                case 5:
                    Console.WriteLine("소띠");
                    break;

                case 6:
                    Console.WriteLine("범띠");
                    break;

                case 7:
                    Console.WriteLine("토끼띠");
                    break;

                case 8:
                    Console.WriteLine("용띠");
                    break;

                case 9:
                    Console.WriteLine("뱀띠");
                    break;

                case 10:
                    Console.WriteLine("말띠");
                    break;

                case 11:
                    Console.WriteLine("양띠");
                    break;

            }
        }

        // p.141 5번문제
        public static void season()
        {
            Console.Write("현재 몇 월인가요? : ");
            int mon = int.Parse(Console.ReadLine());

            switch(mon)
            {
                case 12: case 1: case 2:
                    Console.WriteLine("겨울입니다.");
                    break;

                case 3: case 4: case 5:
                    Console.WriteLine("봄입니다.");
                    break;

                case 6: case 7: case 8:
                    Console.WriteLine("여름입니다.");
                    break;

                case 9: case 10: case 11:
                    Console.WriteLine("가을입니다.");
                    break;
            }
        }

        public static void change_switch()
        {
            Console.Write("학년을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());

            switch (level)
            {
                case 1:
                    Console.WriteLine("수강해야 하는 전공 학점 : 12학점");
                    break;
               
                case 2: case 4:
                    Console.WriteLine("수강해야 하는 전공 학점 : 18학점");
                    break;
               
                case 3:
                    Console.WriteLine("수강해야 하는 전공 학점 : 10학점");
                    break;
            }

        }
    }
}
