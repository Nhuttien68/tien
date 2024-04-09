using System;

namespace Bai_1
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
                Console.WriteLine("3. Kiem tra sinh vien");
                Console.WriteLine("4. Xoa sinh vien");
                Console.WriteLine("5. Thoat chuong trinh");

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
                        function.ThemSinhVien();
                        break;
                    case 2:
                        function.HienThiDanhSachSinhVien();
                        break;
                    case 3:
                        function.KiemTraSinhVien();
                        break;
                    case 4:
                        function.XoaSinhVien();
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Chuong trinh ket thuc.");
                        break;
                }
            }
        }
    }
}
