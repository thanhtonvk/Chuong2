namespace Bai8
{
    public abstract class DaGiac
    {
        private int soCanh;
        private double[] chieuDai;


        protected DaGiac(int soCanh)
        {
            this.soCanh = soCanh;
            chieuDai = new double[soCanh];
        }

        protected DaGiac()
        {
        }

        public int SoCanh
        {
            get => soCanh;
            set => soCanh = value;
        }

        public double[] ChieuDai
        {
            get => chieuDai;
            set => chieuDai = value;
        }

        public virtual double ChuVi()
        {
            return 0;
        }

        public virtual double DienTich()
        {
            return 0;
        }
    }
}