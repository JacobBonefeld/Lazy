using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy
{
    public class Product
    {
        public Product(int price, int ID)
        {
            this.Price = price;
            this.ID = ID;
        }
        public int Price { get; set; }

        public int ID { get; set; }
    }
}
