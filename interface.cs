using System;
namespace OOPInterface
{
    public class Jadwal
    {
        void Show();
    }
    class Baca : Jadwal
    {
        
		
		public void Show()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Jadwal Mata Kuliah");
            Console.WriteLine("UNIVERSITAS AMIKOM YOGYAKARTA");
            Console.WriteLine("**************************************");
        }
		
		
	}
}
