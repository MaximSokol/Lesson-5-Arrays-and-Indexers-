using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_.Task_2
{
    class MyArray
    {
        int[] arr = null;
        Random rand = null;
        //------------------------------------------------------

        public MyArray()
        {
            arr = new int[10];
            rand = new Random();
        }
        //------------------------------------------------------

        public void FillInArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
        }
        //------------------------------------------------------

        public void ShowArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //------------------------------------------------------

        public void MaxValue()
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i]; 
                }
            }
            Console.WriteLine(max);
        }
        //------------------------------------------------------
        public void MinValue()
        {
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
        //------------------------------------------------------

        public int TotalSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //------------------------------------------------------

        public int AverageSum()
        {
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            return avg / arr.Length;
        }
        //------------------------------------------------------

        public void UnEvenElements()
        {
            int unEven = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               if(!(arr[i] % 2 == 0))
                {
                    unEven = arr[i];
                    Console.WriteLine("UnEven\t" + unEven);
                }
            }
        }
        //------------------------------------------------------


    }
}
