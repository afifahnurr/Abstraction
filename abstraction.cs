using System;
namespace Abstraction
{
    class Program
    {

    }

    abstract class Matkul
    {
        public Abstract void ShowInformasi(string senin, string selasa, string rabu, string kamis, string jum'at, string sabtu);
        public void ShowMatkul(string Senin, string Selasa, string Kamis, string Sabtu);
        {
			Console.WriteLine("*********************************");
            Console.WriteLine("Jadwal Mata Kuliah");
            Console.WriteLine("Senin 07.00-09.00        : {0}",senin);
            Console.WriteLine("Selasa 08.00-10.00     	: {0}",selasa);
            Console.WriteLine("Rabu 08.30-10.30			: {0}",rabu);
            Console.WriteLine("Kamis 07.00-08.00     	: {0}",kamis);
            Console.WriteLine("Jumat 10.00-12.00      	: {0}",jumat);
            Console.WriteLine("Sabtu 12.30-14.30       	: {0}",sabtu);
            Console.WriteLine("*********************************");
        }

    }
    class Informasi : Matkul
    {
        public override void ShowInformasi(string Senin, string Selasa, string Kamis, string Sabtu);
        {
            Console.WriteLine("Jadwal Tambahan");
            Console.WriteLine("Senin 11.00-12.00      	: {0}", Senin);
            Console.WriteLine("Selasa 13.00-15.00		: {0}", Selasa);
            Console.WriteLine("Kamis 10.40-12.40     	: {0}", Kamis);
            Console.WriteLine("Sabtu 08.00-09.00    	: {0}", Sabtu);
            Console.WriteLine();
        }
    }
}