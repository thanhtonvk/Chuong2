using System;

namespace Bai4
{
    internal class Program
    {
        private static CanBo[] dsCB;

        public static void NhapCanBo()
        {
            Console.Write("Nhap so luong can bo van phong: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong giang vien: ");
            int m = int.Parse(Console.ReadLine());
            dsCB = new CanBo[n + m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap can bo van phong thu " + (i + 1));
                CanBoVanPhong cb = new CanBoVanPhong();
                cb.Nhap();
                dsCB[i] = cb;
                Console.Clear();
            }

            for (int i = n; i < m + n; i++)
            {
                Console.WriteLine("Nhap can bo giang vien thu " + (i - n + 1));
                GiangVien giangVien = new GiangVien();
                giangVien.Nhap();
                dsCB[i] = giangVien;
                Console.Clear();
            }
        }

        public static void HienThiDSCanBo()
        {
            for (int i = 0; i < dsCB.Length; i++)
            {
                if (dsCB[i] is CanBoVanPhong)
                {
                    Console.WriteLine("Can bo van phong");
                    ((CanBoVanPhong) dsCB[i]).Hien();
                }
                else if (dsCB[i] is GiangVien)
                {
                    Console.WriteLine("Giang vien");
                    ((GiangVien) dsCB[i]).Hien();
                }
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void SapXep()
        {
            for (int i = 0; i < dsCB.Length; i++)
            {
                for (int j = 1; j < dsCB.Length; j++)
                {
                    double luong1 = 0;
                    double luong2 = 0;
                    if (dsCB[i] is CanBoVanPhong)
                    {
                        luong1 = ((CanBoVanPhong) dsCB[i]).Luong();
                    }
                    else if (dsCB[i] is GiangVien)
                    {
                        luong1 = ((GiangVien) dsCB[i]).Luong();
                    }

                    if (dsCB[j] is CanBoVanPhong)
                    {
                        luong2 = ((CanBoVanPhong) dsCB[j]).Luong();
                    }
                    else if (dsCB[j] is GiangVien)
                    {
                        luong2 = ((GiangVien) dsCB[j]).Luong();
                    }

                    if (luong1 < luong2)
                    {
                        CanBo tmp = dsCB[i];
                        dsCB[i] = dsCB[j];
                        dsCB[j] = tmp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Nhap can bo 2. Hien can bo 3.Sap xep 4. Thoat");
                int chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        NhapCanBo();
                        break;
                    case 2:
                        HienThiDSCanBo();
                        break;
                    case 3:
                        SapXep();
                        HienThiDSCanBo();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default: break;
                    
                }
            }   
        }
    }
}