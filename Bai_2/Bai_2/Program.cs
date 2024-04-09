using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function function = new Function();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Thoat chuong trinh");

                Console.Write("Nhap lua chon cua ban: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                    Console.Write("Nhap lua chon cua ban: ");
                }

                switch (choice)
                {
                    case 1:
                        function.AddStudent();
                        break;
                    case 2:
                        function.DisplayStudentInfo();
                        break;
                    case 3:
                        exit = true;
                        Console.WriteLine("Chuong trinh ket thuc.");
                        break;
                }
            }
        }
    }
}
