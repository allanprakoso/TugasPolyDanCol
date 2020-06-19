using System;
using System.Collections.Generic;
namespace TugasPolyDanCol
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "123-234-345";
            karyawantetap.Nama = "Michael Suyama";
            karyawantetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "123-321-213";
            karyawanharian.Nama = "Laura Callahan";
            karyawanharian.JumlahJamKerja = 8;
            karyawanharian.UpahPerJam = 13000;

            Sales sales = new Sales();
            sales.Nik = "789-987-798";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            List<Karyawan> listkaryawan = new List<Karyawan>();
            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int nourut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. NIK : {1}, Nama: {2}, Gaji: {3:N0}",
                    nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                nourut++;
            }

            Console.ReadKey();
        }
    }
}
