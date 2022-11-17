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
    class Program
    {
        static void Main(string[] args)
        {
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

            Store store = new Store(2);
            store.AddElem(new Article("laptop", "Eldorado", 25000), 0);
            store.AddElem(new Article("laptop", "Eldorado", 25000), 1);

            Console.WriteLine(store[1]);
            //----------------------------------------------------------
        }
    }
}
