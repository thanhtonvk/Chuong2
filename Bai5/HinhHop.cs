using System;

namespace Bai5
{
    public class HinhHop : Hinh
    {
        private double dai, rong, cao;

        public HinhHop(double dai, double rong, double cao)
        {
            this.dai = dai;
            this.rong = rong;
            this.cao = cao;
        }

        public HinhHop()
        {
        }

        public double Dai
        {
            get => dai;
            set => dai = value;
        }

        public double Rong
        {
            get => rong;
            set => rong = value;
        }

        public double Cao
        {
            get => cao;
            set => cao = value;
        }

        public void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            dai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            rong = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu cao: ");
            cao = double.Parse(Console.ReadLine());
        }

        public override double DienTich()
        {
            return 2 * (cao * dai + cao * rong + dai * rong);
        }

        public override double TheTich()
        {
            return dai * rong * cao;
        }
    }
}