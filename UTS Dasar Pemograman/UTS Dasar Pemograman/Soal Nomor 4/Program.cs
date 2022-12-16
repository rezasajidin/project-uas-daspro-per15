using System;

namespace SoalNomor4UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            char userinput = ' ';
            int poinmenang = 0;
            int poinkalah = 0;
            int poinseri = 0;
            Random rnd = new Random();

            while (userinput != 'e')
            {
                Console.WriteLine("Selamat datang di Game Batu,Gunting dan Kertas");
                Console.WriteLine("");
                Console.Write("Masukan pilihan anda(b/g/k/e) : ");
                userinput = Convert.ToChar(Console.ReadLine());

                if(userinput == 'e')
                {
                    Console.WriteLine("Selamat tinggal...");
                    break;
                }

                int kom = rnd.Next(1,4);
                if (userinput == 'b')
                {
                    if (kom == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil seri!");
                        poinseri++;
                    }
                    else if (kom == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Kita menang!");
                        poinmenang++;
                    }
                    else if (kom == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Kamu kalah!");
                        poinkalah++;
                    }
                }
                else if( userinput == 'g')
                {
                    if (kom == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Kamu kalah!");
                        poinkalah++;
                    }
                    else if (kom == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil seri!");
                        poinseri++;
                    }
                    else if (kom == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Kamu menang!");
                        poinmenang++;
                    }
                }
                else if (userinput == 'k')
                {
                    if (kom == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Kamu menang!");
                        poinmenang++;
                    }
                    else if (kom == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Kamu kalah!");
                        poinkalah++;
                    }
                    else if (kom == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Hasil seri!");
                        poinseri++;
                    }
                }
                Console.WriteLine("Skor kamu : {0} - {1} - {2}", poinmenang, poinseri, poinkalah);
                Console.WriteLine("Tekan enter untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
        } 
    }
}
