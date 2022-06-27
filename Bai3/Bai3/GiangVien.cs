using System;

namespace Bai3
{
    public class GiangVien
    {
        private string maGv, tenGv, gioiTinh, chuyenNganh;

        public GiangVien(string maGv, string tenGv, string gioiTinh, string chuyenNganh)
        {
            this.maGv = maGv;
            this.tenGv = tenGv;
            this.gioiTinh = gioiTinh;
            this.chuyenNganh = chuyenNganh;
        }

        public GiangVien()
        {
        }

        public string MaGv
        {
            get => maGv;
            set => maGv = value;
        }

        public string TenGv
        {
            get => tenGv;
            set => tenGv = value;
        }

        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string ChuyenNganh
        {
            get => chuyenNganh;
            set => chuyenNganh = value;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten giang vien: ");
            tenGv = Console.ReadLine();
            Console.Write("Chon gioi tinh 1. Nam 2. Nu: ");
            int gt = int.Parse(Console.ReadLine());
            if (gt == 1) gioiTinh = "Nam";
            else gioiTinh = "Nu";
            Console.Write("Chon chuyen nhanh: 1. Tu Nhien 2. Xa Hoi");
            int cn = int.Parse(Console.ReadLine());
            if (cn == 1)
            {
                chuyenNganh = "Tu Nhien";
            }
            else
            {
                chuyenNganh = "Xa Hoi";
            }
        }

        public void Hien()
        {
            Console.WriteLine("Ma Gv: " + maGv + " Ho ten: " + tenGv + " Gioi tinh: " + gioiTinh + "Chuyen nganh: " +
                              chuyenNganh);
        }
    }
}