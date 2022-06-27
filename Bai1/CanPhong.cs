using System;

namespace Bai1
{
    public class CanPhong
    {
        private double dai, rong;

        public CanPhong(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public CanPhong()
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

        public double DienTich()
        {
            return dai * rong;
        }

        public void HienThi()
        {
            Console.WriteLine("Chiều dài: "+dai+ " Chiểu rộng: "+rong+" Diện tích: "+DienTich());
        }

        public void Nhap()
        {
            Console.Write("Nhập chiều dài: ");
            dai = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            rong = double.Parse(Console.ReadLine());
        }
    }
}