using System;

class Program
{
    // Hàm generic để tìm giá trị lớn nhất giữa hai giá trị
    static T Max<T>(T value1, T value2) where T : IComparable<T>
    {
        if (value1.CompareTo(value2) > 0)
        {
            return value1;
        }
        else
        {
            return value2;
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\nSo sánh max giữa 2 giá trị");
            Console.WriteLine("1. Số nguyên");
            Console.WriteLine("2. Số thực");
            Console.WriteLine("3. Chuỗi");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // So sánh 2 số nguyên
                    CompareIntegers();
                    break;
                case "2":
                    // So sánh 2 số thực
                    CompareDoubles();
                    break;
                case "3":
                    // So sánh độ dài 2 chuỗi
                    CompareStrings();
                    break;
                case "4":
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    // So sánh 2 số nguyên
    static void CompareIntegers()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên thứ nhất: ");
                int int1 = int.Parse(Console.ReadLine());

                Console.Write("Nhập số nguyên thứ hai: ");
                int int2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Giá trị lớn nhất giữa {int1} và {int2} là: {Max(int1, int2)}");
                break; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ! Vui lòng nhập lại.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }

    // So sánh 2 số thực
    static void CompareDoubles()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập số thực thứ nhất: ");
                double double1 = double.Parse(Console.ReadLine());

                Console.Write("Nhập số thực thứ hai: ");
                double double2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"Giá trị lớn nhất giữa {double1} và {double2} là: {Max(double1, double2)}");
                break; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ! Vui lòng nhập lại.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }

    // So sánh độ dài 2 chuỗi
    static void CompareStrings()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập chuỗi thứ nhất: ");
                string string1 = Console.ReadLine();

                Console.Write("Nhập chuỗi thứ hai: ");
                string string2 = Console.ReadLine();

                Console.WriteLine($"Giá trị lớn nhất giữa \"{string1}\" và \"{string2}\" là: \"{Max(string1, string2)}\"");
                break; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}
