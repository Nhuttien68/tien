using System;
using System.Collections.Generic;

internal class Function
{
    MyList<Student> studentList = new MyList<Student>();
    public void ThemSinhVien()
    {
        Console.WriteLine("\nNhap thong tin sinh vien:");
        int StudentID;
        bool check = false;
        do
        {
            Console.Write("Nhap ma sinh vien: ");
            while (!int.TryParse(Console.ReadLine(), out StudentID) || StudentID <= 0)
            {
                Console.WriteLine("Ma sinh vien khong hop le. Vui long nhap lai.");
                Console.Write("Nhap ma sinh vien: ");
            }
            bool studentExists = false;
            foreach (Student student in studentList)
            {
                if (student.StudentID == StudentID)
                {
                    studentExists = true;
                    Console.WriteLine("Ma sinh vien da ton tai trong danh sach. Vui long nhap lai.");
                    break;
                }
            }
            if (!studentExists)
            {
                check = true;
            }
        } while (!check);
        string StudentName;
        while (true)
        {
            Console.Write("Nhap ten sinh vien: ");
            StudentName = Console.ReadLine();
            if (!CheckXSSInput(StudentName) || !chuakitudacbiet(StudentName))
            {
                studentList.Add(new Student(StudentID, StudentName));
                Console.WriteLine("Da them sinh vien thanh cong.");
                break;
            }
            else
            {
                Console.WriteLine("Ten sinh vien khong duoc chua ky tu dac biet hoac cac the HTML. Vui long nhap lai.");
            }
        }
    }
    public void HienThiDanhSachSinhVien()
    {
        Console.WriteLine("\nDanh sach sinh vien:");
        for (int i = 0; i < studentList.Count; i++)
        {
            Console.WriteLine(studentList.getStudent(i));
        }
    }
    public void KiemTraSinhVien()
    {
        Console.Write("\nNhap ma sinh vien can kiem tra: ");
        int StudentID;
        while (!int.TryParse(Console.ReadLine(), out StudentID) || StudentID <= 0)
        {
            Console.WriteLine("Ma sinh vien khong hop le. Vui long nhap lai.");
            Console.Write("Nhap ma sinh vien can kiem tra: ");
        }
        bool studentFound = false;
        foreach (Student student in studentList)
        {
            if (student.StudentID == StudentID)
            {
                studentFound = true;
                break;
            }
        }
        if (studentFound)
        {
            Console.WriteLine($"Sinh vien co ma {StudentID} ton tai trong danh sach.");
        }
        else
        {
            Console.WriteLine($"Sinh vien co ma {StudentID} khong ton tai trong danh sach.");
        }
    }
    public void XoaSinhVien()
    {
        Console.Write("\nNhap ma sinh vien can xoa: ");
        int StudentID;
        while (!int.TryParse(Console.ReadLine(), out StudentID) || StudentID <= 0)
        {
            Console.WriteLine("Ma sinh vien khong hop le. Vui long nhap lai.");
            Console.Write("Nhap ma sinh vien can xoa: ");
        }
        Student studentToRemove = null;
        foreach (Student student in studentList)
        {
            if (student.StudentID == StudentID)
            {
                studentToRemove = student;
                break;
            }
        }
        if (studentToRemove != null)
        {
            studentList.Remove(studentToRemove);
            Console.WriteLine($"Da xoa sinh vien co ma {StudentID}.");
            HienThiDanhSachSinhVien();
        }
        else
        {
            Console.WriteLine($"Sinh vien co ma {StudentID} khong ton tai trong danh sach.");
        }
    }
    public bool CheckXSSInput(string input)
    {
        try
        {
            var listdangerousString = new List<string> { "<applet", "<body", "<embed", "<frame", "<script", "<frameset", "<html", "<iframe", "<img", "<style", "<layer", "<link", "<ilayer", "<meta", "<object", "<h", "<input", "<a", "&lt", "&gt" };
            if (string.IsNullOrEmpty(input)) return false;
            foreach (var dangerous in listdangerousString)
            {
                if (input.Trim().ToLower().IndexOf(dangerous) >= 0) return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool chuakitudacbiet(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
            {
                return true;
            }
        }
        return false;
    }
}
