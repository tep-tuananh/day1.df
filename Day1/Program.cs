// See https://aka.ms/new-console-template for more information
using Day1;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.UTF8;
Category[] categories = new Category[4];
categories[0] = new Category(1,"Comuter");
categories[1] = new Category(2, "Menmory");
categories[2] = new Category(3, "Card");
categories[3] = new Category(4, "Acsesory");

Product[] products = new Product[4];
products[0] = new Product("CPU", 6, 20, 1);
products[1] = new Product("RAM", 11, 15, 2);
products[2] = new Product("HDD", 8, 9, 3);
products[3] = new Product("MAIN", 10, 20, 4);

List<Category> list = new List<Category>();
list.Add(categories[0]);
list.Add(categories[1]);
list.Add(categories[2]);
list.Add(categories[3]);

List<Product> productsList = new List<Product>();
productsList.Add(products[0]);
productsList.Add(products[1]);
productsList.Add(products[2]);
productsList.Add(products[3]);
Boolean checkOut = true;
do
{
    Console.WriteLine("----------- MENU -------------------");
    Console.WriteLine("1:Tìm kiếm sản phẩm theo tên sản phẩm: ");
    Console.WriteLine("2: Tìm kiếm sản phẩm theo id sản phẩm");
    Console.WriteLine("3: Tìm kiêm sản phẩm theo giá của sản phẩm");
    Console.WriteLine("4: Sắp xếp danh sách sản phẩm theo giá tăng dần");
    Console.WriteLine("0: Thoát chương trình");
    Console.WriteLine("Lựa chọn của bạn: ");
    try
    {
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine("Nhập vào tên sản phẩn cần tìm: ");
                    string nameProduct = Console.ReadLine().ToUpper();
                    findProductName(productsList, nameProduct);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Nhập mã sản phảm: ");
                    try
                    {
                        int categoryId = int.Parse(Console.ReadLine());
                        findCategoryId(productsList, categoryId);
                    }catch(Exception e)
                    {
                        Console.WriteLine("Lỗi khi nhập vào mã danh mục sản phẩm");
                    }
                    break;
                }
            case 3:
                {
                    try
                    {
                        Console.WriteLine("Nhập vào giá của sản phẩm");
                        int price = int.Parse(Console.ReadLine());  
                        findProductByPrice(productsList, price);
                    }catch(Exception e)
                    {
                        Console.WriteLine("Lỗi khi nhập vào giá của sản phẩm");
                    }
                    break;
                }
            case 4:
                {
                    sortByPrice(productsList);
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Thông tin sản phẩm");
                        Console.WriteLine("Tên sản phẩm : " + products[i].getName());
                        Console.WriteLine("Giá sản phẩm: " + products[i].getPrice());
                        Console.WriteLine("Số lượng sản phẩm" + products[i].getQuantity());
                        Console.WriteLine("Mã danh mục  : " + products[i].getCategoryId()); ;
                    }
                }
                break;
                }
            case 0:
                {
                    Console.WriteLine("Thoát chương trình");
                    checkOut = false;
                    break;
                }
        }
    }catch(Exception e)
    {
        Console.WriteLine("Lỗi khi nhập vào lựa chọn!");
    }
} while (checkOut); 

static void findProductName(List<Product> productList,string name)
{   
    bool checkOut = false;
    for (int i = 0; i < productList.Count; i++)
    {

        if (productList[i].getName().Equals(name)) {
            checkOut = true;
        }
        if (checkOut)
        {
            Console.WriteLine("Thông tin sản phẩm");
            Console.WriteLine("Tên sản phẩm : "+productList[i].getName());
            Console.WriteLine("Giá sản phẩm: "+productList[i].getPrice());
            Console.WriteLine("Số lượng sản phẩm"+productList[i].getQuantity());
            Console.WriteLine("Mã danh mục : "+productList[i].getCategoryId());
        }
    }
    if (!checkOut)
    {
        Console.WriteLine("Không tìm thấy");
    } 
}

static void findCategoryId(List<Product> products ,int categoryId)
{
   Boolean  checkout=true;
    for(int i=0; i< products.Count; i++)
    {
        if (products[i].getCategoryId() == categoryId)
        {
            checkout = true;
            Console.WriteLine("Thông tin sản phẩm");
            Console.WriteLine("Tên sản phẩm : " + products[i].getName());
            Console.WriteLine("Giá sản phẩm: " + products[i].getPrice());
            Console.WriteLine("Số lượng sản phẩm" + products[i].getQuantity());
            Console.WriteLine("Mã danh mục  : " + products[i].getCategoryId());
        }
    }
    if (!checkout)
    {
        Console.WriteLine("Không tìm thấy mã danh mục");
    }
}
static void findProductByPrice(List<Product> products ,int price)
{
    Boolean checkOut = true;
    for (int i = 0; i < products.Count; i++)
    {
        if (products[i].getPrice() >= price)
        {
            Console.WriteLine("Thông tin sản phẩm");
            Console.WriteLine("Tên sản phẩm : " + products[i].getName());
            Console.WriteLine("Giá sản phẩm: " + products[i].getPrice());
            Console.WriteLine("Số lượng sản phẩm" + products[i].getQuantity());
            Console.WriteLine("Mã danh mục  : " + products[i].getCategoryId());
        }
    }
    if (!checkOut)
    {
        Console.WriteLine("Không tìm thấy mệnh  giá sản phẩm này");
    }
}
static void sortByPrice(List<Product> products)
{
    int n = products.Count;
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (products[j].getPrice() > products[j + 1].getPrice())
            {
                Product item = products[j];
                products[j] = products[j + 1];
                products[j + 1] = item;
            }
        }
    }
}
