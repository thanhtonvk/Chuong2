using System;

namespace Bai9
{
    public class SinhVien
    {
        private string hoTen, namSinh;

        public SinhVien()
        {
        }

        public SinhVien(string hoTen, string namSinh)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
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

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = Console.ReadLine();
        }
    }
}