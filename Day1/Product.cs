using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Product
    {
        private string name { get; set; }
        private int price { get; set; }
        private int quantity { get; set; }
        private int categoryId { get; set; }

        public Product (string name , int price , int quantity, int categoryId)
        {
            this.name = name;
            this.price = price;
            this.quantity= quantity;
            this.categoryId = categoryId;
        }
        public Product() { }

        public string getName()
        {
            return this.name;
        }
        public int getPrice()
        {
            return this.price;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        public int getCategoryId()
        {
            return this.categoryId;
        }

        public static implicit operator List<object>(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
