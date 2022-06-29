using System;

namespace Bai5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Hinh tron 2.Hinh hop 3.Thoat");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        HinhTron hinhTron = new HinhTron();
                        hinhTron.Nhap();
                        Console.Clear();
                        Console.WriteLine("1. Tinh dien tich 2.Thoat");
                        int tron = int.Parse(Console.ReadLine());
                        if (tron == 1)
                        {
                            Console.WriteLine("Dien tich hinh tron la: " + hinhTron.DienTich());
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        HinhHop hinhHop = new HinhHop();
                        hinhHop.Nhap();
                        Console.Clear();
                        Console.WriteLine("1.Tinh dien tich 2.Tinh the tich 3.Thoat");
                        int hop = int.Parse(Console.ReadLine());
                        if (hop == 1)
                        {
                            Console.WriteLine("Dien tich hinh hop: " + hinhHop.DienTich());
                        }
                        else if (hop == 2)
                        {
                            Console.WriteLine("The tich hinh hop la: " + hinhHop.TheTich());
                        }

                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default: break;
                }
            }
        }
    }
}