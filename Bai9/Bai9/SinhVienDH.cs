using System;

namespace Bai9
{
    public class SinhVienDH : SinhVienCD
    {
        private double diemNam4;

        public SinhVienDH(double diemNam1, double diemNam2, double diemNam3, double diemNam4) : base(diemNam1, diemNam2,
            diemNam3)
        {
            this.diemNam4 = diemNam4;
        }

        public SinhVienDH(string hoTen, string namSinh, double diemNam1, double diemNam2, double diemNam3,
            double diemNam4) : base(hoTen, namSinh, diemNam1, diemNam2, diemNam3)
        {
            this.diemNam4 = diemNam4;
        }

        public SinhVienDH(double diemNam4)
        {
            this.diemNam4 = diemNam4;
        }

        public SinhVienDH()
        {
        }

        public void Nhap()
        {
            base.Nhap();
            while (true)
            {
                Console.Write("Nhap diem nam 4: ");
                diemNam4 = Double.Parse(Console.ReadLine());
                if (diemNam4 >= 0 && diemNam4 <= 10) break;
            }
        }
        public double DiemTongKet()
        {
            return (DiemNam1 + DiemNam2 + DiemNam3+diemNam4) / 4;
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