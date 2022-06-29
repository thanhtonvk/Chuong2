using System;

namespace Bai7
{
    public class NhanVienCongTruong : NhanVienHanhChinh
    {
        private string namCongTac;
        private double phuCap;

        public NhanVienCongTruong(string namCongTac, double phuCap )
        {
            this.namCongTac = namCongTac;
            this.phuCap = phuCap;
          
        }

        public NhanVienCongTruong(double hsLuong, string noiLamViec, string namCongTac, double phuCap)
            : base(hsLuong, noiLamViec)
        {
            this.namCongTac = namCongTac;
            this.phuCap = phuCap;
         
        }

        public NhanVienCongTruong(string hoTen, string namSinh, string queQuan, double luong, double hsLuong,
            string noiLamViec, string namCongTac, double phuCap) : base(hoTen, namSinh, queQuan,
            luong, hsLuong, noiLamViec)
        {
            this.namCongTac = namCongTac;
            this.phuCap = phuCap;
         
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

        public override double TinhLuong()
        {
            return (Luong * HsLuong) + PhuCap;
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
            Console.WriteLine("Nam cong tac: " + namCongTac + " Phu cap: " + PhuCap + " Tong luong: " + TinhLuong());
        }
    }
}