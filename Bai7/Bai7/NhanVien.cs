using System;

namespace Bai7
{
    public class NhanVien
    {
        private string hoTen, namSinh, queQuan;
        private double luong;

        public NhanVien()
        {
        }

        public NhanVien(string hoTen, string namSinh, string queQuan, double luong)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.queQuan = queQuan;
            this.luong = luong;
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

        public double Luong
        {
            get => luong;
            set => luong = value;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            queQuan = Console.ReadLine();
            Console.Write("Nhap luong: ");
            luong = double.Parse(Console.ReadLine());
        }

        public virtual double TinhLuong()
        {
            return 0;
        }

        public void Xuat()
        {
            Console.WriteLine(
                "Ho ten: " + hoTen + " Nam sinh: " + namSinh + " Que quan: " + queQuan + " Luong " + luong);
        }
    }
}