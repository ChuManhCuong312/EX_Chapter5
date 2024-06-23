using System;
using System.Collections;

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Product(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        ArrayList productList = new ArrayList();

        while (true)
        {
            Console.WriteLine("\n1. Thêm sản phẩm mới");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    //Thêm sản phẩm mới
                    AddProduct(productList);
                    break;
                case "2":
                    //Hiển thị danh sách sản phẩm
                    DisplayProducts(productList);
                    break;
                case "3":
                    //Tìm kiếm sản phẩm theo tên
                    SearchProduct(productList);
                    break;
                case "4":
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ, vui lòng chọn lại.");
                    break;
            }
        }
    }

    //Thêm sản phẩm mới
    static void AddProduct(ArrayList productList)
    {
        Console.Write("Nhập tên sản phẩm: ");
        string name = Console.ReadLine();

        Console.Write("Nhập mô tả sản phẩm: ");
        string description = Console.ReadLine();

        double price;
        while (true)
        {
            Console.Write("Nhập giá sản phẩm: ");
            if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá không hợp lệ, vui lòng nhập lại.");
            }
        }

        productList.Add(new Product(name, description, price));
        Console.WriteLine("Đã thêm sản phẩm mới thành công.");
    }

    //Hiển thị danh sách sản phẩm
    static void DisplayProducts(ArrayList productList)
    {
        Console.WriteLine("\nDanh sách sản phẩm:");

        if (productList.Count == 0)
        {
            Console.WriteLine("Không có sản phẩm nào trong danh sách.");
        }
        else
        {
            foreach (Product product in productList)
            {
                Console.WriteLine($"Tên: {product.Name}, Mô tả: {product.Description}, Giá: {product.Price}");
            }
        }
    }

    //Tìm kiếm sản phẩm theo tên
    static void SearchProduct(ArrayList productList)
    {
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string searchName = Console.ReadLine();

        bool found = false;
        foreach (Product product in productList)
        {
            if (product.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Tên: {product.Name}, Mô tả: {product.Description}, Giá: {product.Price}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không tìm thấy sản phẩm nào với tên đã nhập.");
        }
    }
}

