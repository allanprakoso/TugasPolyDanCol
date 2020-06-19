namespace TugasPolyDanCol
{
    class Sales : Karyawan
    {
        public int Komisi;

        public double JumlahPenjualan;

        public override double Gaji()
        {
            return (Komisi * JumlahPenjualan);
        }
    }
}