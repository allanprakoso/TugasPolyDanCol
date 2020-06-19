namespace TugasPolyDanCol
{
    class KaryawanHarian : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;

        public override double Gaji()
        {
            return (UpahPerJam * JumlahJamKerja);
        }
    }
}