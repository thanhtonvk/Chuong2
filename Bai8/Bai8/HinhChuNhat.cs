using System;

namespace Bai8
{
    public class HinhChuNhat:DaGiac
    {
        public HinhChuNhat(int soCanh) : base(2)
        {
        }

        public HinhChuNhat():base(2)
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
            return (ChieuDai[0] + ChieuDai[1]) * 2;
        }

        public override double DienTich()
        {
            return ChieuDai[0] * ChieuDai[1];
        }
    }
}