using System;

namespace Bai9
{
    public class SinhVienCD : SinhVien
    {
        private double diemNam1, diemNam2, diemNam3;

        public SinhVienCD(double diemNam1, double diemNam2, double diemNam3)
        {
            this.diemNam1 = diemNam1;
            this.diemNam2 = diemNam2;
            this.diemNam3 = diemNam3;
        }

        public SinhVienCD(string hoTen, string namSinh, double diemNam1, double diemNam2, double diemNam3) : base(hoTen,
            namSinh)
        {
            this.diemNam1 = diemNam1;
            this.diemNam2 = diemNam2;
            this.diemNam3 = diemNam3;
        }

        public SinhVienCD()
        {
        }

        public double DiemNam1
        {
            get => diemNam1;
            set => diemNam1 = value;
        }

        public double DiemNam2
        {
            get => diemNam2;
            set => diemNam2 = value;
        }

        public double DiemNam3
        {
            get => diemNam3;
            set => diemNam3 = value;
        }

        public void Nhap()
        {
            base.Nhap();
            while (true)
            {
                Console.Write("Nhap diem nam 1: ");
                diemNam1 = double.Parse(Console.ReadLine());
                if (diemNam1 >= 0 && diemNam1 <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem nam 2: ");
                diemNam2 = double.Parse(Console.ReadLine());
                if (diemNam2 >= 0 && diemNam2 <= 10) break;
            }

            while (true)
            {
                Console.Write("Nhap diem nam 3: ");
                diemNam3 = double.Parse(Console.ReadLine());
                if (diemNam3 >= 0 && diemNam3 <= 10) break;
            }
        }

        public double DiemTongKet()
        {
            return (diemNam1 + diemNam2 + diemNam3) / 3;
        }

        public void Hien()
        {
            string diemChu;
            double diemTongKet = DiemTongKet();
            if (diemTongKet >= 8.5 && diemTongKet <= 10) diemChu = "A";
            else if (diemTongKet > 7.0 && diemTongKet <= 8.4) diemChu = "B";
            else if (diemTongKet >= 5.5 && diemTongKet <= 6.9) diemChu = "C";
            else if (diemTongKet >= 4.0 && diemTongKet <= 5.4) diemChu = "D";
            else diemChu = "F";
            Console.WriteLine("Ho ten: " + HoTen + " Nam sinh: " + NamSinh +" Diem so: "+diemTongKet + " Diem chu: " + diemChu);
        }
        
    }
}