using System;

namespace Bai2
{
    public class NhanVienCongTruong : NhanVienHanhChinh
    {
        private string namCongTac;
        private double phuCap;
        private double tongLuong;

        public NhanVienCongTruong(string namCongTac, double phuCap, double tongLuong)
        {
            this.namCongTac = namCongTac;
            this.phuCap = phuCap;
            this.tongLuong = tongLuong;
        }

        public NhanVienCongTruong(double hsLuong, string noiLamViec, string namCongTac, double phuCap, double tongLuong)
            : base(hsLuong, noiLamViec)
        {
            this.namCongTac = namCongTac;
            this.phuCap = phuCap;
            this.tongLuong = tongLuong;
        }

        public NhanVienCongTruong(string hoTen, string namSinh, string queQuan, double luong, double hsLuong,
            string noiLamViec, string namCongTac, double phuCap, double tongLuong) : base(hoTen, namSinh, queQuan,
            luong, hsLuong, noiLamViec)
        {
            this.namCongTac = namCongTac;
            this.phuCap = phuCap;
            this.tongLuong = tongLuong;
        }

        public NhanVienCongTruong()
        {
        }

        public string NamCongTac
        {
            get => namCongTac;
            set => namCongTac = value;
        }

        public double PhuCap
        {
            get => Luong * 0.25;
            set => phuCap = value;
        }

        public double TongLuong
        {
            get => (Luong * HsLuong) + PhuCap;
            set => tongLuong = value;
        }

        public  void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nam cong tac: ");
            namCongTac = Console.ReadLine();
        }

        public void Xuat2()
        {
            Xuat1();
            Console.WriteLine("Nam cong tac: " + namCongTac + " Phu cap: " + PhuCap + " Tong luong: " + TongLuong);
        }
    }
}