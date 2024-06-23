using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo Dictionary
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        // Thêm cặp key-giá trị vào Dictionary
        dictionary.Add(1, "Một");
        dictionary.Add(2, "Hai");
        dictionary.Add(3, "Ba");
        dictionary.Add(4, "Bốn");
        dictionary.Add(5, "Năm");

        // Kiểm tra sự tồn tại của một key trong Dictionary
        Console.WriteLine("Kiểm tra key '2': " + dictionary.ContainsKey(2));
        Console.WriteLine("Kiểm tra key '6': " + dictionary.ContainsKey(6));

        // Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một key nhất định
        if (dictionary.TryGetValue(3, out string value))
        {
            Console.WriteLine("Giá trị của key '3': " + value);
        }
        else
        {
            Console.WriteLine("Key '3' không tồn tại.");
        }

        // Lặp qua các mục KeyValuePair<TKey, TValue> trong Dictionary và in chúng
        Console.WriteLine("\nCác cặp key-giá trị trong Dictionary:");
        foreach (KeyValuePair<int, string> kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
