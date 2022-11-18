using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5__Arrays_and_Indexers_.Task_1;
using Lesson_5__Arrays_and_Indexers_.Task_2;
using Lesson_5__Arrays_and_Indexers_.Task_3;
using Lesson_5__Arrays_and_Indexers_.Task_4;

namespace Lesson_5__Arrays_and_Indexers_
{
    class MyClass<T>
    {
        public static T[] values = new T[10];
        static int newIndex = 0;
        //------------------------------------

        public T this[int index] => values[index];
        //------------------------------------------------

        public static void AddElement(T value)
        {
            if (newIndex >= values.Length)
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }
            values[newIndex++] = value;
        }
        //------------------------------------------------
    }

    class Program
    {
        static void Main()
        {
            MyClass<int> obj = new MyClass<int>();
            MyClass<int>.AddElement(20);
            Console.WriteLine(obj[0]);

            // Task 1

            //----------------------------------------------------------

            //var translator = new Translator();

            //Console.Write("Enter the word ->");
            //string word = Console.ReadLine();

            //Console.WriteLine(translator[word]);

            //----------------------------------------------------------

            // Task 2

            //----------------------------------------------------------

            //var myArray = new MyArray();
            //myArray.FillInArray();
            //myArray.MaxValue();
            //myArray.MinValue();
            //Console.WriteLine(myArray.TotalSum());
            //Console.WriteLine(myArray.AverageSum());
            //myArray.UnEvenElements();

            //----------------------------------------------------------

            // Task 3

            //----------------------------------------------------------

            //Matrix m = new Matrix(4, 5);

            //Console.WriteLine(new string('-', 30));
            //Console.WriteLine("[1][2] = {0}", m[1, 2]);
            //Console.WriteLine("[6][2] = {0}", m[6, 2]);
            //m[0, 0] = 11;

            //Console.WriteLine(new string('-', 30));
            //m.ChengeSize(7, 6);

            //----------------------------------------------------------

            // Task 4

            //----------------------------------------------------------

            Store store = new Store(3);
            store.AddElem(0, new Article("laptop", "Eldorado", 25000));
            store.AddElem(1, new Article("smartphone", "Apple", 15600));
            store.AddElem(2, new Article("a clock", "Rolex", (int)190_000));

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(store[i]);
            }
            //----------------------------------------------------------
        }
    }
}
