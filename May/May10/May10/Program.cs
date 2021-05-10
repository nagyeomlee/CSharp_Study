using System;
using System.Collections.Generic;

namespace May10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class_print();
            //List_Class();
            //List_element_add();
            List_element_remove();
        }

        static void Class_print()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(Math.Round(random.NextDouble(), 4)); // 랜덤 실수 발행, 소수점 4자리까지 출력

        }

        static void List_Class()
        {
            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];
            List<int> list = new List<int>();

        }

        static void List_element_add()
        {
            List<int> list = new List<int>();

            list.Add(52);
            list.Add(573);
            list.Add(32);
            list.Add(64);

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }

        }

        static void List_element_remove()
        {
            List<int> list = new List<int>() { 11, 22, 33, 44 };
            list.Remove(33);
            
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }
        }
    }
}
