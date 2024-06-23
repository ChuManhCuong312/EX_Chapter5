using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        // Tạo Hashtable
        Hashtable hashtable = new Hashtable();

        // Thêm cặp key-giá trị vào Hashtable
        hashtable.Add(1, "Một");
        hashtable.Add(2, "Hai");
        hashtable.Add(3, "Ba");
        hashtable.Add("Bốn", 4.0);
        hashtable.Add("Năm", 5);

        // Kiểm tra sự tồn tại của một key trong Hashtable
        Console.WriteLine("Kiểm tra key '2': " + hashtable.ContainsKey(2));
        Console.WriteLine("Kiểm tra key '6': " + hashtable.ContainsKey(6));

        // Kiểm tra sự tồn tại của một giá trị trong Hashtable
        Console.WriteLine("Kiểm tra giá trị 'Hai': " + hashtable.ContainsValue("Hai"));
        Console.WriteLine("Kiểm tra giá trị 'Mười': " + hashtable.ContainsValue("Mười"));

        // Truy xuất giá trị được liên kết với một key nhất định
        Console.WriteLine("Giá trị của key '3': " + hashtable[3]);
        Console.WriteLine("Giá trị của key 'Bốn': " + hashtable["Bốn"]);

        // Lặp qua các key của Hashtable và in chúng
        Console.WriteLine("\nCác key trong Hashtable:");
        foreach (var key in hashtable.Keys)
        {
            Console.WriteLine(key);
        }

        // Lặp qua các giá trị của Hashtable và in chúng
        Console.WriteLine("\nCác giá trị trong Hashtable:");
        foreach (var value in hashtable.Values)
        {
            Console.WriteLine(value);
        }

        // Lặp qua các cặp key-giá trị của Hashtable và in chúng
        Console.WriteLine("\nCác cặp key-giá trị trong Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
