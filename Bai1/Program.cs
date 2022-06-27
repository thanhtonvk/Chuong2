using System;
using System.Text;

namespace Bai1
{
    internal class Program
    {
        private static CanPhong[] dsPhong;

        public static void NhapThongTin()
        {
            Console.Write("Nhập số lượng: ");
            int n = int.Parse(Console.ReadLine());
            dsPhong = new CanPhong[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập căn phòng số " + (i + 1) + " : ");
                ChiPhi chiPhi = new ChiPhi();
                chiPhi.Nhap();
                dsPhong[i] = chiPhi;
            }
        }

        public static void HienThi()
        {
            int n = dsPhong.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin căn phòng số " + (i + 1) + " : ");
                ChiPhi chiPhi = dsPhong[i] as ChiPhi;
                chiPhi.HienThi();
            }
        }

        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            bool kt = true;
            while (kt)
            {
                Console.WriteLine("Chọn chức năng: ");
                Console.WriteLine("1. Nhập phòng: ");
                Console.WriteLine("2. Hiển thị");
                Console.WriteLine("3. Thoát");
                int chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        NhapThongTin();
                        Console.Clear();
                        break;
                    case 2:
                        HienThi();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Thông báo");
                        Console.WriteLine("Y: Thực hiện tiếp, N: Thoát chương trình");
                        string c = Console.ReadLine();
                        if (c == "Y")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            kt = false;
                            break;
                        }
                    default: break;
                }
            }
        }
    }
}