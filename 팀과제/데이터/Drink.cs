using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 팀과제.데이터
{
    internal class Drink
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Drink(string name)
        {
            Name = name;
        }

        public Drink(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}

