using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Function
    {
        private Dictionary<int, string> students = new Dictionary<int, string>();
        public void AddStudent()
        {
            Console.WriteLine("\nNhap thong tin sinh vien:");
            int studentID;
            bool check = false;
            do
            {
                Console.Write("Nhap ma sinh vien: ");
                while (!int.TryParse(Console.ReadLine(), out studentID) || studentID <= 0)
                {
                    Console.WriteLine("Ma sinh vien khong hop le. Vui long nhap lai.");
                    Console.Write("Nhap ma sinh vien: ");
                }
                // Sử dụng ContainsKey để kiểm tra sự tồn tại của khóa
                if (this.students.ContainsKey(studentID)) 
                {
                    Console.WriteLine("Ma sinh vien da ton tai trong danh sach. Vui long nhap lai.");
                }
                else
                {
                    check = true;
                }
            } while (!check);
            string studentName;
            while (true)
            {
                Console.Write("Nhap ten sinh vien: ");
                studentName = Console.ReadLine();
                if (!CheckXSSInput(studentName) || !chuakitudacbiet(studentName))
                {
                    this.students.Add(studentID, studentName);
                    Console.WriteLine("Da them sinh vien thanh cong.");
                    break;
                }
                else
                {
                    Console.WriteLine("Ten sinh vien khong duoc chua ky tu dac biet hoac cac the HTML. Vui long nhap lai.");
                }
            }
        }



        public void DisplayStudentInfo()
        {
            Console.Write("Nhap ma sinh vien can hien thi thong tin: ");
            int studentIDInfo;
            while (!int.TryParse(Console.ReadLine(), out studentIDInfo) || studentIDInfo <= 0)
            {
                Console.WriteLine("Ma sinh vien khong hop le. Vui long nhap lai.");
                Console.Write("Nhap ma sinh vien: ");
            }

            if (students.ContainsKey(studentIDInfo))
            {
                Console.WriteLine($"Ma sinh vien: {studentIDInfo}, Ten sinh vien: {students[studentIDInfo]}");
            }
            else
            {
                Console.WriteLine($"Sinh vien co ma {studentIDInfo} khong ton tai trong danh sach.");
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
}
