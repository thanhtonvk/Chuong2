using System;

namespace Bai1
{
    public class ChiPhi:CanPhong
    {
        private double donGia;

        public ChiPhi(double dai, double rong, double donGia) : base(dai, rong)
        {
            this.donGia = donGia;
        }

        public ChiPhi(double donGia)
        {
            this.donGia = donGia;
        }

        public ChiPhi()
        {
        }

        public double DonGia
        {
            get => donGia;
            set => donGia = value;
        }

        public double TongChiPhi()
        {
            return DienTich() * donGia;
        }

        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Đơn giá: "+donGia+" Chi phí: "+TongChiPhi());
        }

        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập đơn giá: ");
            donGia= double.Parse(Console.ReadLine());
        }
    }
}