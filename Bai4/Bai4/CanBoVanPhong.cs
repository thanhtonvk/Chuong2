using System;

namespace Bai4
{
    public class CanBoVanPhong : CanBo
    {
        private double phuCap;

        public CanBoVanPhong(string maCb, string hoTen, string namSinh, string queQuan, double lcb, double hsl,
            double phuCap) : base(maCb, hoTen, namSinh, queQuan, lcb, hsl)
        {
            this.phuCap = phuCap;
        }

        public CanBoVanPhong(double phuCap)
        {
            this.phuCap = phuCap;
        }

        public CanBoVanPhong()
        {
        }

        public double PhuCap
        {
            get => Lcb * 0.1;
            set => phuCap = value;
        }

        public double Luong()
        {
            return (Lcb * Hsl) + phuCap;
        }

        public void Hien()
        {
            base.Hien();
            Console.WriteLine("Phu cap: " + PhuCap + " Luong: " + Luong());
        }
    }
}