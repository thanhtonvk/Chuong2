using System;

namespace Bai4
{
    public class CanBo
    {
        private string maCB, hoTen, namSinh, queQuan;
        private double lcb, hsl;

        public CanBo(string maCb, string hoTen, string namSinh, string queQuan, double lcb, double hsl)
        {
            maCB = maCb;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.queQuan = queQuan;
            this.lcb = lcb;
            this.hsl = hsl;
        }

        public CanBo()
        {
        }

        public string MaCb
        {
            get => maCB;
            set => maCB = value;
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public double Lcb
        {
            get => lcb;
            set => lcb = value;
        }

        public double Hsl
        {
            get => hsl;
            set => hsl = value;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten can bo: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            queQuan = Console.ReadLine();
            Console.Write("Nhap luong co ban: ");
            lcb = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so luong: ");
            hsl = Double.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            Console.WriteLine("Ho ten: " + hoTen + " Nam sinh: " + namSinh + " Que quan: " + queQuan +
                              " Luong co ban: " + lcb + " He so luong: " + hsl);
        }
    }
}