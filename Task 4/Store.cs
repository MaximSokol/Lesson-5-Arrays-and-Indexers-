using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_.Task_4
{
    class Store
    {
        private Article []arr;
        //----------------------------------------------------

        public Store(int size)
        {
            arr = new Article[size];
        }
        //----------------------------------------------------

        public string AddElem(int index, Article elem)
        {
            if (index >= 0 && index <= arr.Length)
                arr[index] = elem;

            return @"The trying to get access behind the array!";
        }
        //----------------------------------------------------

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= arr.Length)
                    return arr[index].Info();
                return @"The trying to get access behind the array!";
            }
        }
        //----------------------------------------------------

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Name == index)
                        return arr[i].Info();
                }
                return "No any such numbers!";
            }               
        }
        //----------------------------------------------------

        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Info());
            }
        }
        //----------------------------------------------------
    }
}
