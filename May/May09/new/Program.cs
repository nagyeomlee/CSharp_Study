using System;

namespace May09_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Print_foreach();
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







//        public static void Print_foreach()
//        {
//            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

//            foreach (var item in array)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
