using System;

namespace Bai3
{
    public class SinhVien
    {
        private string maSv, tenSv, gioiTinh, lop, khoa;

        public SinhVien(string maSv, string tenSv, string gioiTinh, string lop, string khoa)
        {
            this.maSv = maSv;
            this.tenSv = tenSv;
            this.gioiTinh = gioiTinh;
            this.lop = lop;
            this.khoa = khoa;
        }

        public SinhVien()
        {
        }

        public string MaSv
        {
            get => maSv;
            set => maSv = value;
        }

        public string TenSv
        {
            get => tenSv;
            set => tenSv = value;
        }

        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string Lop
        {
            get => lop;
            set => lop = value;
        }

        public string Khoa
        {
            get => khoa;
            set => khoa = value;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten sinh vien: ");
            tenSv = Console.ReadLine();
            Console.Write("Chon gioi tinh 1. Nam 2. Nu: ");
            int gt = int.Parse(Console.ReadLine());
            if (gt == 1) gioiTinh = "Nam";
            else gioiTinh = "Nu";
            Console.Write("Nhap lop: ");
            lop = Console.ReadLine();
            Console.Write("Chon khoa 1. Toan Tin 2.Ngoai Ngu ");
            int k = int.Parse(Console.ReadLine());
            if (k == 1) khoa = "Toan Tin";
            else khoa = "Ngoai Ngu";
            
        }

        public void Hien()
        {
            Console.WriteLine("Ma sv: "+maSv+" Ho ten: "+tenSv+" Lop: "+lop+" Khoa: "+khoa);
        }
    }
}