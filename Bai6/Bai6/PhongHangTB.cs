using System;

namespace Bai6
{
    public class PhongHangTB:Phong
    {
        private double donGiaTB;

        public PhongHangTB(double donGiaTb)
        {
            donGiaTB = donGiaTb;
        }

        public PhongHangTB(double chieuDai, double chieuRong, double donGiaTb) : base(chieuDai, chieuRong)
        {
            donGiaTB = donGiaTb;
        }

        public PhongHangTB()
        {
        }

        public double DonGiaTb
        {
            get => donGiaTB;
            set => donGiaTB = value;
        }

        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap don gia: ");
            donGiaTB = double.Parse(Console.ReadLine());
        }

        public override double ChiPhi()
        {
            return DienTich() * donGiaTB;
        }

        public void Hien()
        {
            base.Hien();
            Console.WriteLine("Chi phi: "+ChiPhi());
        }
    }
}