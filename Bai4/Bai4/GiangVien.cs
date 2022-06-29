using System;

namespace Bai4
{
    public class GiangVien:CanBo
    {
        private double phuCapGiangDay;
        private int thamNien;

        public GiangVien(string maCb, string hoTen, string namSinh, string queQuan, double lcb, double hsl, double phuCapGiangDay, int thamNien) : base(maCb, hoTen, namSinh, queQuan, lcb, hsl)
        {
            this.phuCapGiangDay = phuCapGiangDay;
            this.thamNien = thamNien;
        }

        public GiangVien(double phuCapGiangDay, int thamNien)
        {
            this.phuCapGiangDay = phuCapGiangDay;
            this.thamNien = thamNien;
        }

        public GiangVien()
        {
        }

        public double PhuCapGiangDay
        {
            get => Lcb*0.4;
            set => phuCapGiangDay = value;
        }

        public int ThamNien
        {
            get => thamNien;
            set => thamNien = value;
        }

        public double PhuCapThamNiem()
        {
            if (thamNien > 5) return Lcb * 0.1;
            return 0;
        }

        public double Luong()
        {
            return (Lcb * Hsl) + PhuCapGiangDay + PhuCapThamNiem();
        }

        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap tham nien: ");
            thamNien = int.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            base.Hien();
            Console.WriteLine("Phu cap giang day: "+PhuCapGiangDay+" Phu cap tham niem: "+PhuCapThamNiem()+" Luong: "+Luong());
        }
    }
}