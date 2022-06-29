using System;

namespace Bai10
{
    public class SinhVienVL : SinhVien
    {
        private double coHoc, dienHoc, quangHoc, vatLyHatNhan;

        public SinhVienVL(double coHoc, double dienHoc, double quangHoc, double vatLyHatNhan)
        {
            this.coHoc = coHoc;
            this.dienHoc = dienHoc;
            this.quangHoc = quangHoc;
            this.vatLyHatNhan = vatLyHatNhan;
        }

        public SinhVienVL()
        {
            
        }

        public double CoHoc
        {
            get => coHoc;
            set => coHoc = value;
        }

        public double DienHoc
        {
            get => dienHoc;
            set => dienHoc = value;
        }

        public double QuangHoc
        {
            get => quangHoc;
            set => quangHoc = value;
        }

        public double VatLyHatNhan
        {
            get => vatLyHatNhan;
            set => vatLyHatNhan = value;
        }

        public override double Dtb()
        {
            return (coHoc + dienHoc + quangHoc + vatLyHatNhan) / 4;
        }

        public void Nhap()
        {
            base.Nhap();
            while (true)
            {
                Console.Write("Nhap diem co hoc: ");
                coHoc = double.Parse(Console.ReadLine());
                if (coHoc >= 0 && coHoc <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem dien hoc: ");
                dienHoc = double.Parse(Console.ReadLine());
                if (dienHoc >= 0 && dienHoc <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem quang hoc: ");
                quangHoc = double.Parse(Console.ReadLine());
                if (quangHoc >= 0 && quangHoc <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem vat ly hat nhan: ");
                vatLyHatNhan = double.Parse(Console.ReadLine());
                if (vatLyHatNhan >= 0 && vatLyHatNhan <= 10) break;
            }
        }

        public void Hien()
        {
            base.Hien();
            Console.WriteLine("Chuyen nganh: Vat ly");
            Console.WriteLine("Diem trung binh: " + Dtb());
        }
    }
}