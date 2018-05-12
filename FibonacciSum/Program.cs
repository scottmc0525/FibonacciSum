using System;
using System.Collections.Generic;

namespace FibonacciSum
{
    class EvenFibonacciSum
    {
        private int currentIndex = 0;
        List<int> arrayList = new List<int>();
        private int sum = 0;

        public int CurrentIndex { get => currentIndex; set => currentIndex = value; }
        public int Sum { get => sum; set => sum = value; }

        public EvenFibonacciSum()
        {
            init();
        }

        public void init()
        {
            arrayList.Add(1);
            arrayList.Add(2);
            CurrentIndex = 1;
            Sum = 2;
        }

        public int GetFibonacciNumbers(int upperLimit)
        { 
            while (arrayList[CurrentIndex] < upperLimit)
            {
                arrayList.Add((arrayList[CurrentIndex] + arrayList[CurrentIndex - 1]));
                CurrentIndex++;

                if (arrayList[CurrentIndex] % 2 == 0)
                {
                    Sum += arrayList[CurrentIndex];
                }

                
            }

            return Sum;
        }

        public void PrintFibonacci()
        {
            foreach(int item in arrayList)
            {
                Console.WriteLine("FN: " + item);
            }
        }

        static void Main(string[] args)
        {
            EvenFibonacciSum euler2 = new EvenFibonacciSum();
            euler2.GetFibonacciNumbers(4000000);
            euler2.PrintFibonacci();
            Console.WriteLine("Sum is " + euler2.Sum);
            Console.WriteLine("Max index was " + euler2.CurrentIndex);
            Console.WriteLine("Max Value was " + euler2.arrayList[euler2.CurrentIndex]);
        }
    }
}
