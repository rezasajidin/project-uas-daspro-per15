using System;

namespace SoalNomor2UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int jawab = 0;
            Random rnd = new Random();
            int cek = rnd.Next(1,101);
            while (jawab != cek)
            {
                Console.WriteLine("Tebak angka antara 1-100 : ");
                jawab = Convert.ToInt32(Console.ReadLine());
                if (jawab < cek)
                {
                    Console.WriteLine("Salah. angka terlalu rendah.");
                }else if (jawab > cek){
                    Console.WriteLine("Salah. angka terlalu tinggi.");
                }else{
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Byee..")
                    Console.ReadKey();
                }
            }
        }
    }
}
