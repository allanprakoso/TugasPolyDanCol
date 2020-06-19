namespace TugasPolyDanCol
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan;
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}