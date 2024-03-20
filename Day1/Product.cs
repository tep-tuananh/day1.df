using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Product
    {
        private string name;
        private int price;
        private int quantity;
        private int categoryId;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }

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
        public void getAll(List<Product> products,int i)
        {
            Console.WriteLine("Tên sản phẩm: " + products[i].getName()  + " Giá sản phẩm: "+ products[i].getPrice());
            Console.WriteLine("Số lượng sản phẩm: " + products[i].getQuantity() + " Mã danh mục: " + products[i].getCategoryId());
        }
        public void getProduct()
        {
            Console.WriteLine("Tên sản phẩm: " + name + " Giá sản phẩm: " + price);
            Console.WriteLine("Số lượng sản phẩm: " + quantity + " Mã danh mục: " +categoryId);

        }

    }


}
