// See https://aka.ms/new-console-template for more information
using Day1;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Category[] categories = new Category[4];
        categories[0] = new Category(1, "Comuter");
        categories[1] = new Category(2, "Menmory");
        categories[2] = new Category(3, "Card");
        categories[3] = new Category(4, "Acsesory");

        Product[] products = new Product[4];
        products[0] = new Product("CPU", 6, 20, 1);
        products[1] = new Product("RAM", 5, 15, 2);
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

        // dựng  cờ check thoát chương trình
        Boolean checkOut = true;
        do
        {
            Product product = new Product();
            Console.WriteLine("----------- MENU -------------------");
            Console.WriteLine("1:Tìm kiếm sản phẩm theo tên sản phẩm: ");
            Console.WriteLine("2: Tìm kiếm sản phẩm theo id sản phẩm");
            Console.WriteLine("3: Tìm kiêm sản phẩm theo giá của sản phẩm");
            Console.WriteLine("4: Sắp xếp danh sách sản phẩm theo giá tăng dần");
            Console.WriteLine("5: Sắp xếp theo tên giảm dần");
            Console.WriteLine("6: Tìm ra sản phẩm có giá nhỏ nhất");
            Console.WriteLine("7: Tìm ra sản phẩm có giá lớn nhất");
            Console.WriteLine("8: Tính lương trong n năm");
            Console.WriteLine("9: Tìm số tháng để tiền gửi ngân hàng gấp đôi");
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
                            findProductName(productsList, nameProduct, product);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhập mã sản phảm: ");
                            try
                            {
                                int categoryId = int.Parse(Console.ReadLine());
                                findCategoryId(productsList, categoryId);
                            }
                            catch (Exception e)
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
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Lỗi khi nhập vào giá của sản phẩm");
                            }
                            break;
                        }
                    case 4:
                        {
                            sortByPrice(productsList);

                        }
                        break;
                    case 5:
                        {
                            sortByName(productsList);
                            break;
                        }
                    case 6:
                        {
                            minByPrice(productsList);
                            break;
                        }
                    case 7:
                        {
                            maxByPrice(productsList);
                            break;
                        }
                    case 8:
                        {
                            calSalary();
                            break;
                        }
                    case 9:
                        {
                            calMonth();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Thoát chương trình");
                            checkOut = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("adasdsad");
                            break;
                        }



                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi khi nhập vào lựa chọn!");
            }
        } while (checkOut);
        // tìm kiến tên sản phẩm trong danh sách sản phẩm
        // tìm kiếm đúng tên
        static void findProductName(List<Product> productList, string name, Product product)
        {
            bool checkOut = false;
            for (int i = 0; i < productList.Count; i++)
            {

                if (productList[i].getName().Equals(name))
                {
                    checkOut = true;
                    product.getAll(productList, i);
                }

            }
            if (!checkOut)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        // tìm kiếm sản phẩm qua mã danh  mục
        static void findCategoryId(List<Product> products, int categoryId)
        {
            Product product = new Product();
            Boolean checkout = true;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].getCategoryId() == categoryId)
                {
                    checkout = true;
                    Console.WriteLine("Thông tin sản phẩm");
                    product.getAll(products, i);
                }
            }
            if (!checkout)
            {
                Console.WriteLine("Không tìm thấy mã danh mục");
            }
        }
        // tìm kiếm sản phẩm qua giá của sản phẩm truyền vào
        static void findProductByPrice(List<Product> products, int price)
        {
            Boolean checkOut = true;
            for (int i = 0; i < products.Count; i++)
            {
                Product product = new Product();
                if (products[i].getPrice() >= price)
                {
                    Console.WriteLine("Thông tin sản phẩm");
                    product.getAll(products, i);
                }
            }
            if (!checkOut)
            {
                Console.WriteLine("Không tìm thấy mệnh  giá sản phẩm này");
            }
        }
        // sắp xếp danh  sách sản phẩm tăng dần  dựa vào giá sản phẩm 
        static void sortByPrice(List<Product> products)
        {

            int n = products.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (products[j].getPrice() > products[j + 1].getPrice())
                    {
                        Product item = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = item;
                    }
                }
            }
            for (int i = 0; i < products.Count; i++)
            {
                Product product = new Product();
                Console.WriteLine("");
                Console.WriteLine("Thông tin sản phẩm");
                product.getAll(products, i);
            }
        }
        // sắp xếp danh  sách sản phẩm dựa vào tên sản phẩm 
        static void sortByName(List<Product> products)
        {
            int i, j;
            Product product = new Product();
            for (i = 1; i < products.Count; i++)
            {
                j = i - 1;
                product = products[i];
                while (j >= 0 && product.getName().Length > products[j].getName().Length)
                {
                    products[j + 1] = products[j];
                    j--;
                }
                products[j + 1] = product;
            }
            for (int k = 0; k < products.Count; k++)
            {
                Console.WriteLine("");
                Console.WriteLine("Thông tin sản phẩm");
                product.getAll(products, i);
            }
        }
        // tìm ra sản phẩm có giá nhỏ nhất

        static void minByPrice(List<Product> products)
        {
            Product product = products[0];
            for (int i = 0; i < products.Count; i++)
            {
                if (product.getPrice() > products[i].getPrice())
                {
                    product = products[i];
                }
            }
            Console.WriteLine("Sản phẩm có giá nhỏ nhất!"); ;
            product.getProduct();
        }
        // tìm ra sản phẩm có giá cao nhất
        static void maxByPrice(List<Product> products)
        {
            Product product = products[0];
            for (int i = 0; i < products.Count; i++)
            {
                if (product.getPrice() < products[i].getPrice())
                {
                    product = products[i];
                }
            }
            Console.WriteLine("Sản phẩm có giá nhỏ nhất!"); ;
            Console.WriteLine("Thông tin sản phẩm");
            product.getProduct();  
        }
        // cách tính lương 
        static void calSalary()
        {
            {
                Console.WriteLine("Nhập vào hệ số lương: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập vào hệ số năm: ");
                int y = int.Parse(Console.ReadLine());
                bool checkOut = true;
                do
                {
                    Console.WriteLine("1: Dùng đệ quy: ");
                    Console.WriteLine("2: Không dùng đệ quy");
                    Console.WriteLine("0: Thoát");
                    Console.WriteLine("Lựa chọn: ");
                    try
                    {
                        int luaChon = int.Parse(Console.ReadLine());
                        switch (luaChon)
                        {
                            case 0:
                                {
                                    checkOut = false;
                                    break;
                                }
                            case 1:
                                {
                                    Console.WriteLine("Tổng số tiền trong " + y + " là: " + sum(salary, y));
                                    break;
                                }
                            case 2:
                                {
                                    double sumYear = 0;
                                    for (int i = 1; i <= y; i++)
                                    {
                                        sumYear = salary + (salary * 0.1);
                                    }
                                    Console.WriteLine("Tổng tiền trong " + y + " là:  " + sumYear);
                                    break;
                                }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Lỗi khi nhập vào lựa chọn");
                    }

                } while (checkOut);
                // hàm đệ quy
                double sum(Double salary, int y)
                {
                    if (y == 1)
                    {
                        return salary;
                    }
                    else
                    {
                        return salary = salary + (salary * 0.1);
                    }
                }
            }
        }
        // tìm số tháng
        static void calMonth()
        {
            Console.WriteLine("Nhập vào số tiền gửi :");
            int money = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào lãi suất :");
            int rate = int.Parse(Console.ReadLine());
            Boolean checkOut = true;
            do
            {
                Console.WriteLine("1: Dùng đệ quy: ");
                Console.WriteLine("2: Không dùng đệ quy");
                Console.WriteLine("0: Thoát");
                Console.WriteLine("Lựa chọn: ");
                try
                {
                    int luaChon = int.Parse(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 0:
                            {
                                checkOut = false;
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("Số tháng để số tiền gửi gấp đôi tiền gửi: " + month(money, rate));
                                break;
                            }
                        case 2:
                            {
                                double sumMoney = 0;
                                int count = 0;
                                for (int i = 1; ; i++)
                                {
                                    sumMoney = sumMoney + (money * rate / 100);
                                    count++;
                                    if (sumMoney >= 2 * money)
                                    {
                                        break;
                                    }
                                }
                                Console.WriteLine("Số tháng để số tiền gửi gấp đôi tiền gửi: " + count);
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi khi nhập vào lựa chọn");
                }
            } while (checkOut);

            // đệ qui tìm số tháng
            int month(int a, int b)
            {
                int sum = 0;
                int count = 0;
                if (2 * a <= sum)
                {
                    sum = sum + (a * b / 100);
                    count++;
                }
                return count;
            }
        }
    }
}



