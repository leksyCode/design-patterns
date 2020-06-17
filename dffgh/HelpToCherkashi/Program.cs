using System;

namespace HelpToCherkashi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            while (m > 50 || m < 2) 
            {                
                Console.WriteLine("m must be in range [2;50], try again ");
                m = Convert.ToInt32(Console.ReadLine());
            } 
                       
            int[] arr = FullArray(m);
            Output(FindSR(arr), arr);
            
            Console.ReadLine();
        }

        public static void Output(float x, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > x)
                {
                    Console.Write(arr[i] + ", ");
                }
            }
        }

        public static int[] FullArray(int length)
        {
            int[] arr = new int[length];
            Random rn = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rn.Next(-30, 50);
            }

            return arr;
        }

        public static float FindSR(int[] arr)
        {
            int sum = 0, count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 1)
                {
                    sum += arr[i];
                    count++;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;
        }

    }
}
