using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldtect.Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFibonacci();
            TestBubbleSort();
        }

        public static void TestFibonacci()
        {
            Console.WriteLine("TestFibonacci:");

            for (int i = 0; i < 20; i++)
                Console.Write(string.Format("{0} ",FibonacciAlgorithm.Fibonacci(i)));

            Console.WriteLine();
        }

        public static void TestBubbleSort()
        {
            Console.WriteLine("TestBubbleSort:");

            int[] arr = new int[] { 99, 88, 88, 66, 102, -22};

            BubbleSortAlgorithm.Sort(ref arr);

            foreach (var i in arr)
                Console.Write(string.Format("{0} ", i));

            Console.WriteLine();
        }
    }
}
