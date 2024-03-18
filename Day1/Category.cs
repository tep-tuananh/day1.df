using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Category
    {
        private int id { get; set; }
        private String name { get; set; }
        public Category(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public Category() { 
        }
        public int getId()
        {
            return id;
        }
        public String getName()
        {
            return name;
        }
    }
}
