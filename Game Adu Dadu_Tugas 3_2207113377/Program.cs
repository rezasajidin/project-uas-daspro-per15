using System;

namespace AduDadu
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerSatu;
            int playerDua;

            int pointSatu = 0;
            int pointDua = 0;

            Random rng = new Random();

            Console.WriteLine("PERMAINAN ADU DADU\n");                
            Console.WriteLine("Permainan dadu ini ada 10 level");
            Console.WriteLine("Setiap level kamu akan melempar dadu dan mendapatkan angka acak");
            Console.WriteLine("Angka tertinggi adalah pemenangnya");
            Console.WriteLine("Apakah kamu yang akan menjadi pemenangnya? Mari mulai!\n");

            for (int i = 1; i <= 10; i++)
            {
                
                               
                Console.WriteLine("Level " +i);

                playerSatu = rng.Next(1, 7);
                Console.WriteLine("Angka dadu Dia = " +playerSatu);
                Console.WriteLine("Giliran Kamu!");
                Console.WriteLine("...");
                Console.ReadKey();

                playerDua = rng.Next(1, 7);
                Console.WriteLine("Angka Dadu Kamu = " +playerDua);
                

                if(playerSatu > playerDua)
                {
                    pointSatu++;
                    Console.WriteLine("Dia memenangkan Level ini!");
                    Console.WriteLine();

                }
                else if(playerDua > playerSatu)
                {
                    pointDua++;
                    Console.WriteLine("Kamu memenangkan Level ini!");
                    Console.WriteLine();

                }
                else 

                {
                    Console.WriteLine("Angka kamu dan dia sama!");
                    Console.WriteLine();

                }

                Console.WriteLine("Total point saat ini : ");
                Console.WriteLine("Kamu = "+pointDua);
                Console.WriteLine("Dia = "+pointSatu);

                Console.WriteLine("Klik apapun untuk melanjukan....");
                Console.WriteLine();
                Console.WriteLine("==========================================================");
                Console.WriteLine();
                Console.ReadKey();
            }
            if(pointDua > pointSatu)
            {
                Console.WriteLine("Selamat!Kamu adalah pemenangnya!");
            }
            else if(pointSatu > pointDua)
            {
                Console.WriteLine("Sayang sekali kamu kalah... :(");
            }
            else
            {
                Console.WriteLine("Kamu dan dia seri! Mau coba lagi?");
            }
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("TERIMAKASIH TELAH BERMAIN!");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("Dibuat Oleh : ");
            Console.WriteLine("Nama : Muhammad Reza Sajidin");
            Console.WriteLine("NIM : 2207113377");
            Console.WriteLine("Kelas : Teknik Informatika - A");
            Console.ReadKey();
            
        }
    }
}
