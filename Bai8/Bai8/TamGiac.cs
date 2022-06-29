using System;

namespace Bai8
{
    public class TamGiac : DaGiac
    {
        public TamGiac(int soCanh) : base(3)
        {
        }

        public TamGiac() :base(3)
        {
        }

        public void Nhap()
        {
            for (int i = 0; i < ChieuDai.Length; i++)
            {
                while (true)
                {
                    Console.Write("Nhap canh thu " + (i + 1) + " : ");
                    ChieuDai[i] = double.Parse(Console.ReadLine());
                    if (ChieuDai[i] > 0) break;
                }
            }
        }

        public override double ChuVi()
        {
            return ChieuDai[0] + ChieuDai[1] + ChieuDai[2];
        }

        public override double DienTich()
        {
            double p = (ChieuDai[0] + ChieuDai[1] + ChieuDai[2]) / 2;
            return Math.Sqrt(p * (p - ChieuDai[0]) * (p - ChieuDai[1]) * (p - ChieuDai[2]));
        }
    }
}