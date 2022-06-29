using System;

namespace Bai10
{
    public class SinhVien
    {
        private string hoTen, gioiTinh, ngaySinh;

        public SinhVien()
        {
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioiTinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            ngaySinh = Console.ReadLine();
        }

        public void Hien()
        {
            Console.WriteLine("Ho ten: " + hoTen + " Gioi tinh: " + gioiTinh + " Ngay sinh: " + ngaySinh);
        }

        public virtual double Dtb()
        {
            return 0;
        }
    }
}