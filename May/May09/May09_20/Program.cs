using System;

namespace May09_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam05();
        }

        public static void Exam01()
        {
            int[] array = new int[] { 1, 2, 3 };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void Exam02()
        {
            for (int i = 0; i < 20; i=i+2)
            {
                Console.Write("출력");
            }
        }

        public static void Exam03()
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write("출력");
                i++;
            }    
        }
        
        public static void Exam04()
        {
            int i, j, k;

            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7-i; j++)
                {
                    Console.Write(' ');
                }
                for (k = 0; k < i*2+1; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void Exam05()
        {
            int i = 0, max = 0, min = 0;
            int j = 1;
            int[] numArray = new int[5];
            while (i < 5)
            {
                Console.Write("숫자를 입력해주세요 : ");
                numArray[i] = int.Parse(Console.ReadLine());
                i++;
            }

            while (j < 5)
            {
                max = numArray[0];
                min = numArray[0];

                if (numArray[j] > max)
                    max = numArray[j];

                if (numArray[j] < min)
                    min = numArray[j];
                j++;
            }
            Console.WriteLine("가장 큰 수는 " + max);
            Console.WriteLine("가장 작은 수는 " + min);


        }
    }
}
