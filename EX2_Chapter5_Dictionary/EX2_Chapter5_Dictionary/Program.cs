using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "hello", "xin chào" },
            { "world", "thế giới" },
            { "computer", "máy tính" },
            { "programming", "lập trình" },
            { "language", "ngôn ngữ" },
            { "dictionary", "từ điển" },
            { "code", "mã" },
            { "software", "phần mềm" },
            { "hardware", "phần cứng" },
            { "network", "mạng" },
            {"dictionary", "từ điển" }
        };

        while (true)
        {
            Console.Write("Nhập từ tiếng Anh (hoặc gõ 'exit' để thoát): ");
            string englishWord = Console.ReadLine().Trim().ToLower();

            if (englishWord == "exit")
            {
                Console.WriteLine("Thoát chương trình.");
                break;
            }

            if (dictionary.ContainsKey(englishWord))
            {
                Console.WriteLine($"Nghĩa tiếng Việt: {dictionary[englishWord]}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }
        }
    }
}
