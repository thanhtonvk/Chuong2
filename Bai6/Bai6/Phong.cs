using System;

namespace Bai6
{
    public abstract class Phong
    {
        private double chieuDai, chieuRong;

        public Phong()
        {
        }

        public Phong(double chieuDai, double chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }

        public double DienTich()
        {
            return chieuDai * chieuRong;
        }

        public virtual double ChiPhi()
        {
            return 0;
        }

        public void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            chieuDai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            chieuRong = double.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            Console.WriteLine("Chieu dai: " + chieuDai + " Chieu rong: " + chieuRong + " Dien tich: " + DienTich());
        }
    }
}