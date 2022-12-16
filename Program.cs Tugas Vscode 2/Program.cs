using System;

namespace Daspro
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            int KodeA;
            int KodeB;
            int KodeC;
            int jumlahKode;
            
            String tebakanA;
            String tebakanB;
            String tebakanC;

            int hasilTambah;
            int hasilKali;

            //Inialisasi Variabel
            KodeA = 4;
            KodeB = 8;
            KodeC = 16;

            jumlahKode = 3;

            //Operasi Aritmatika
            hasilTambah = KodeA+KodeB+KodeC;
            hasilKali = KodeA*KodeB*KodeC;

            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("Jika ditambah hasilnya "+hasilTambah);
            Console.WriteLine("Jika dikali hasilnya "+hasilKali);

            //Input User
            Console.Write("Masukan Kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukan Kode 3 : ");
            tebakanC = Console.ReadLine();

            Console.WriteLine("Tebakan Anda : " +tebakanA+ " " +tebakanB+ " " +tebakanC+" ?");

            //If Statement
            if(tebakanA  == KodeA.ToString() && tebakanB == KodeB.ToString() && tebakanC == KodeC.ToString())
            {
                Console.WriteLine("Tebakan Anda Benar!!");
            }else{
                Console.WriteLine("Tebakan Anda Salah!!");
            }

        }

    }
}