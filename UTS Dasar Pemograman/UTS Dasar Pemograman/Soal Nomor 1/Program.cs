using System;

namespace soalnomor1uts
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama, nim, konsentrasi;
            Console.WriteLine("Nama :");
            nama = Console.ReadLine();
            Console.WriteLine("Nim :");
            nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi :");
            konsentrasi = Console.ReadLine();

            Console.WriteLine("|*********************************|");
            Console.WriteLine("{0,-8} {1,26}", "|Nama :",nama+"|");
            Console.WriteLine("{0,-16} {1,18}","|",nim+"|");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("{0,-16} {1,18}","|",konsentrasi+"|");
            Console.WriteLine("**********************************|");



        }
    }
}


