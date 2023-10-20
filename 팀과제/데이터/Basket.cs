using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 팀과제
{
    internal class Basket
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Counter { get; set; }

        public Basket(string name, int price)
        {
            Name = name;
            Price = price;
            Counter = Counter++;
        }
    }
}
