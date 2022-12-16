using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
        static string kataRahasia = "doraemon";
        static int kesempatan = 5;
        static List<string> tebakanPemain = new List<string> ();
        static void Main(string[] args)
        {
            Intro();
            MulaiMain();
            //EndGame
        }

        static void Intro()
        {

            Console.WriteLine("Selamat datang di permainan Tebak Kata");
            Console.WriteLine($"Kamu mempunyai {kesempatan} kesempatan untuk menebak kata rahasia pada permainan ini"); 
            Console.WriteLine("Petunjuknya adalah film animasi di jepang"); 
            Console.WriteLine($"Kata ini terdiri dari {kataRahasia.Length} karakter"); 
            Console.WriteLine("Film apakah yang dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        
        }

        static void MulaiMain(){
            while (kesempatan>0)
            {
                Console.Write("Apa karakter tebakanmu?(a-z) : ");
                string input = Console.ReadLine();
                tebakanPemain.Add(input);

                if (jawaban(kataRahasia,tebakanPemain)){
                    Console.WriteLine("Tebakan anda benar");
                    Console.WriteLine($"Kata Misteri ini hari : {kataRahasia}");
                    break;

                }else if (kataRahasia.Contains(input)){
                    Console.WriteLine("Huruf itu ada didalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya");
                    //
                    Console.WriteLine(cekhuruf(kataRahasia, tebakanPemain));
                }else{
                    Console.WriteLine("Huruf tidak ada...");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");

                }

                if (kesempatan==0)
                {
                    //Console.WriteLine("Mohon maad kesemptan anda Habis");
                    //Console.WriteLine($"Kata misteri yang dimaksud adalah {kataRahasia}.");
                    //Console.WriteLine("Terima kasih sudah bermain");
                    EndGame();
                }
            }
        }
        static bool jawaban(string kataRahasia, List<string> list){
            bool status = false;
            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if (list.Contains(c))
                {
                    status = true;
                }else{
                    return status = false;
                }
            }
                    return status;
        }
        static string cekhuruf(string kataRahasia, List<string> list){
            string x = "";
            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if (list.Contains(c))
                {
                    x = x + c;
                }else{
                    x = x + ".";
                }
            }
            return x;
        }
        static void EndGame(){
            Console.WriteLine("Finish");
            Console.WriteLine($"Jawabannya {kataRahasia}");
        }
    }
}
