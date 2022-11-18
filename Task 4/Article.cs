using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_.Task_4
{
    class Article
    {
        public string Name { get; set; }
        public string NameOfAStore { get; set; }
        public int CostOfAProduct { get; set; }
        //---------------------------------------------------------

        public Article(string name, string nameProd, int cost)
        {
            this.Name = name;
            this.NameOfAStore = nameProd;
            this.CostOfAProduct = cost;
        }
        //---------------------------------------------------------

        public string Info()
        {
            return $"Name:\t\t\t{Name}\n" +
                $"Name of a store:\t{NameOfAStore}\n" +
                $"Cost of a product:\t{CostOfAProduct}\n";
        }
        //---------------------------------------------------------
    }
}
