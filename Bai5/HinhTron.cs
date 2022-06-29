using System;

namespace Bai5
{
    public class HinhTron : Hinh
    {
        private double r;

        public HinhTron(double r)
        {
            this.r = r;
        }

        public HinhTron()
        {
        }

        public double R
        {
            get => r;
            set => r = value;
        }

        public void Nhap()
        {
            Console.Write("Nhap ban kinh: ");
            r = double.Parse(Console.ReadLine());
        }
        public override double DienTich()
        {
            return PI * r * r;
        }

        public override double TheTich()
        {
            return 0;
        }
    }
}