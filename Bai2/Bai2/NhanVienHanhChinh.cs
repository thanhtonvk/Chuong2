using System;

namespace Bai2
{
    public class NhanVienHanhChinh : NhanVien
    {
        private double hsLuong;
        private string noiLamViec;

        public NhanVienHanhChinh()
        {
        }

        public NhanVienHanhChinh(double hsLuong, string noiLamViec)
        {
            this.hsLuong = hsLuong;
            this.noiLamViec = noiLamViec;
        }

        public NhanVienHanhChinh(string hoTen, string namSinh, string queQuan, double luong, double hsLuong,
            string noiLamViec) : base(hoTen, namSinh, queQuan, luong)
        {
            this.hsLuong = hsLuong;
            this.noiLamViec = noiLamViec;
        }

        public double HsLuong
        {
            get => hsLuong;
            set => hsLuong = value;
        }

        public string NoiLamViec
        {
            get => noiLamViec;
            set => noiLamViec = value;
        }

        public  void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong: ");
            hsLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap noi lam viec: ");
            noiLamViec = Console.ReadLine();
        }

        public void Xuat1()
        {
            base.Xuat();
            Console.WriteLine("He so luong: " + hsLuong + " Noi lam viec: " + noiLamViec);
        }
    }
}