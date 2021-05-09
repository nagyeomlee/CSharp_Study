using System;

namespace May09_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Example.Ex01();
        }
    }

    public class Example
    {
        public static void Ex01()
        {
            string str = Console.ReadLine();

            if (str.Contains("나겸"))
            {
                Console.WriteLine("안녕하세요");
            }
            else
            {
                Console.WriteLine("안녕히계세요.");
            }
        }
    }
}
