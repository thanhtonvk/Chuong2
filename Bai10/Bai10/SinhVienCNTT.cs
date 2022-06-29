using System;

namespace Bai10
{
    public class SinhVienCNTT : SinhVien
    {
        private double csharp, pascal, sql;

        public SinhVienCNTT(double csharp, double pascal, double sql)
        {
            this.csharp = csharp;
            this.pascal = pascal;
            this.sql = sql;
        }

        public SinhVienCNTT()
        {
        }

        public void Nhap()
        {
            base.Nhap();
            while (true)
            {
                Console.Write("Nhap diem Csharp: ");
                csharp = double.Parse(Console.ReadLine());
                if (csharp >= 0 && csharp <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem Pascal: ");
                pascal = double.Parse(Console.ReadLine());
                if (pascal >= 0 && pascal <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem SQL: ");
                sql = double.Parse(Console.ReadLine());
                if (sql >= 0 && sql <= 10) break;
            }
        }

        public override double Dtb()
        {
            return (csharp + pascal + sql) / 3;
        }

        public void Hien()
        {
            base.Hien();
            Console.WriteLine("Chuyen nganh cong nghe thong tin");
            Console.WriteLine("Diem trung binh: " + Dtb());
        }
    }
}