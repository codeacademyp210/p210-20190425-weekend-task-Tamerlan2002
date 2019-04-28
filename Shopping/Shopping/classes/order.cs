using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.classes
{
    class Order
    {
        public int Id = 0;
        public int IdInc()
        {
            return Id + 1;
        }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public  int Count { get; set; }
        public Product Price { get; set; }
        public int CalcPrice()
        {
            return Count * Product.Price;
        }


    }
}
