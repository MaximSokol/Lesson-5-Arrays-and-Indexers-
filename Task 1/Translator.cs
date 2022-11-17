using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_.Task_1
{
    public class Translator
    {
        private string[] usa;
        private string[] ru;
        private string[] ua;
        //------------------------------------------------------------------

        public Translator()
        {
            usa = new string[3] { "pilot", "layer", "programmer"};
            ru = new string[3] { "пилот", "адвокат", "программист" };
            ua = new string[3] { "пілот", "захисник", "програміст" };
        }
        //------------------------------------------------------------------

        public string this[string key]
        {
            get 
            {
                for (int i = 0; i < 3; i++)
                {
                   if(usa[i] == key)
                        return usa[i] + " " + ru[i] + " " + ua[i];
                   if(ru[i] == key)
                        return ru[i] + " " + usa[i] + " " + ua[i];
                   if(ua[i] == key)
                        return ua[i] + " " + usa[i] + " " + ru[i];
                }
                return $"The translation for this word is absent!\t{key}";
            }
        }

    }
}
