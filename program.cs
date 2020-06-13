using System;
using Abstraction;
using OOPInterface;
namespace tugas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jadwal desk = new Baca();
            informasi = new Informasi();

            string Senin = "Komunikasi Data";
            string Selasa = "Pemrograman";
            string Rabu = "HardwareSoftware I ";
            string Kamis = " Bahasa Inggris II";
            string Jumat = "Organisasi & Arsitektur Komputer"
            string Sabtu = "Stuktur Data";
            string Minggu = "Sistem Operasi";

            desk.Show();
            ShowInformasi(senin, selasa, rabu, kamis, jumat, sabtu);
            ShowJadwal(Senin, Selasa , Kamis, Sabtu);
        }
    }
}