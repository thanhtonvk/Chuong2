using System;

namespace Bai10
{
    public class SinhVienVan : SinhVien
    {
        private double vanHocCD, vanHocHD;

        public SinhVienVan(double vanHocCd, double vanHocHd)
        {
            vanHocCD = vanHocCd;
            vanHocHD = vanHocHd;
        }

        public SinhVienVan()
        {
        }

        public double VanHocCd
        {
            get => vanHocCD;
            set => vanHocCD = value;
        }

        public double VanHocHd
        {
            get => vanHocHD;
            set => vanHocHD = value;
        }

        public override double Dtb()
        {
            return (vanHocCD + vanHocHD) / 2;
        }

        public void Nhap()
        {
            base.Nhap();
            while (true)
            {
                Console.Write("Nhap diem  van hoc co dien: ");
                vanHocCD = double.Parse(Console.ReadLine());
                if (vanHocCD >= 0 && vanHocCD <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem  van hoc hien dai: ");
                vanHocHD = double.Parse(Console.ReadLine());
                if (vanHocHD >= 0 && vanHocHD <= 10) break;
            }
        }

        public void Hien()
        {
            base.Hien();
            Console.WriteLine("Chuyen nganh: Van hoc");
            Console.WriteLine("Diem trung binh: " + Dtb());
        }
    }
}