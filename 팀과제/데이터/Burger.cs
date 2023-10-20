using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 팀과제
{
    internal class Burger
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Burger(string name)
        {
            Name = name;
        }

        public Burger(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
