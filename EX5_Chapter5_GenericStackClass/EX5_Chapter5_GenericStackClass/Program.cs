using System;
using System.Collections.Generic;

class MyStack<T>
{
    private List<T> stackList;

    public MyStack()
    {
        stackList = new List<T>();
    }
    
    public void Push(T item)
    {
        stackList.Add(item);
    }

    public T Pop()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("Ngăn xếp rỗng");
        }

        T poppedItem = stackList[stackList.Count - 1];
        stackList.RemoveAt(stackList.Count - 1);
        return poppedItem;
    }

    public int Count()
    {
        return stackList.Count;
    }

    public override string ToString()
    {
        if (stackList.Count == 0)
        {
            return "Ngăn xếp rỗng.";
        }
        string result = "Các phần tử trong ngăn xếp: ";
        for (int i = stackList.Count - 1; i >= 0; i--)
        {
            result += stackList[i] + (i == 0 ? "" : ", ");
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\nChọn loại ngăn xếp:");
            Console.WriteLine("1. Số nguyên");
            Console.WriteLine("2. Số thực");
            Console.WriteLine("3. Chuỗi");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Ngăn xếp số nguyên
                    ManageStack<int>();
                    break;
                case "2":
                    //Ngăn xếp số thực
                    ManageStack<double>();
                    break;
                case "3":
                    //Ngăn xếp chuỗi
                    ManageStack<string>();
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

    static void ManageStack<T>()
    {
        MyStack<T> stack = new MyStack<T>();

        while (true)
        {
            Console.WriteLine($"\nQuản lý ngăn xếp loại {typeof(T).Name}:");
            Console.WriteLine("1. Thêm phần tử vào ngăn xếp");
            Console.WriteLine("2. Xóa phần tử khỏi ngăn xếp");
            Console.WriteLine("3. Quay lại menu chính");
            Console.Write("Nhập lựa chọn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Thêm phần tử vào ngăn xếp
                    AddElement(stack);
                    break;
                case "2":
                    //Xóa phần tử khỏi ngăn xếp
                    RemoveElement(stack);
                    break;
                case "3":
                    //Quay lại menu chính
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    //Thêm phần tử vào ngăn xếp
    static void AddElement<T>(MyStack<T> stack)
    {
        try
        {
            Console.Write($"Nhập phần tử ({typeof(T).Name}): ");
            string input = Console.ReadLine();
            T value = (T)Convert.ChangeType(input, typeof(T));
            stack.Push(value);
            Console.WriteLine($"Đã thêm {value} vào ngăn xếp.");
            Console.WriteLine(stack);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}. Vui lòng nhập lại.");
        }
    }

    //Xóa phần tử khỏi ngăn xếp
    static void RemoveElement<T>(MyStack<T> stack)
    {
        try
        {
            T value = stack.Pop();
            Console.WriteLine($"Đã xóa {value} khỏi ngăn xếp.");
            Console.WriteLine(stack);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}. Không có phần tử nào trong ngăn xếp.");
        }
    }
}
