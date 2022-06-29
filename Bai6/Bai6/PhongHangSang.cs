using System;

namespace Bai6
{
    public class PhongHangSang : Phong
    {
        private double donGiaSang, giaTrangTri;

        public PhongHangSang(double donGiaSang, double giaTrangTri)
        {
            this.donGiaSang = donGiaSang;
            this.giaTrangTri = giaTrangTri;
        }

        public PhongHangSang(double chieuDai, double chieuRong, double donGiaSang, double giaTrangTri) : base(chieuDai,
            chieuRong)
        {
            this.donGiaSang = donGiaSang;
            this.giaTrangTri = giaTrangTri;
        }

        public PhongHangSang()
        {
        }

        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap don gia sang: ");
            donGiaSang = double.Parse(Console.ReadLine());
            Console.Write("Nhap gia trang tri: ");
            giaTrangTri = double.Parse(Console.ReadLine());
        }

        public override double ChiPhi()
        {
            return DienTich() * donGiaSang * giaTrangTri;
        }

        public void Hien()
        {
            base.Hien();
            Console.WriteLine("Gia hang sang: " + donGiaSang + " Gia trang tri: " + giaTrangTri + " Chi phi: " + ChiPhi());
        }
    }
}