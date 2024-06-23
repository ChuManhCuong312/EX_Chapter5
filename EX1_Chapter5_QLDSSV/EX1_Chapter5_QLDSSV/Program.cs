using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public string ClassName { get; set; }
    public double Score { get; set; }

    public Student(string name, string className, double score)
    {
        Name = name;
        ClassName = className;
        Score = score;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("\n1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Thêm sinh viên mới
                    AddStudent(students);
                    break;
                case "2":
                    //Hiển thị danh sách sinh viên
                    DisplayStudents(students);
                    break;
                case "3":
                    //Tính tổng điểm của tất cả sinh viên
                    CalculateTotalScore(students);
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

    //Thêm sinh viên mới
    static void AddStudent(List<Student> students)
    {
        Console.Write("Nhập tên sinh viên: ");
        string name = Console.ReadLine();

        Console.Write("Nhập lớp: ");
        string className = Console.ReadLine();

        double score;
        while (true)
        {
            Console.Write("Nhập điểm hệ số 10: ");
            if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10)
            {
                break;
            }
            else
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại.");
            }
        }

        students.Add(new Student(name, className, score));
        Console.WriteLine("Đã thêm sinh viên thành công.");
    }

    //Hiển thị danh sách sinh viên
    static void DisplayStudents(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Không có sinh viên nào trong danh sách.");
            return;
        }

        Console.WriteLine("Danh sách sinh viên:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Tên: {student.Name}, Lớp: {student.ClassName}, Điểm: {student.Score}");
        }
    }

    //Tính tổng điểm của tất cả sinh viên
    static void CalculateTotalScore(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Không có sinh viên nào trong danh sách.");
            return;
        }

        double totalScore = 0;
        foreach (Student student in students)
        {
            totalScore += student.Score;
        }
        Console.WriteLine($"Tổng điểm của tất cả sinh viên: {totalScore}");
    }
}
