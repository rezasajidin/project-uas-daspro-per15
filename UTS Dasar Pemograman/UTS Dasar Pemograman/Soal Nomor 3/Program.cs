using System;

namespace SoalNomor3UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumlahdenda = 0;
            int waktu = 0;
            Console.WriteLine("Input jumlah hari peminjaman : ");
            waktu = Convert.ToInt32(Console.ReadLine());
            if (waktu > 30)
            {
                jumlahdenda = (waktu - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("Total denda: " + jumlahdenda);
                Console.WriteLine("Keanggotaan dibatalkan");
            }else if (waktu > 10){
                jumlahdenda = (waktu - 10) * 20000 + 50000;
                Console.WriteLine("Total denda : " + jumlahdenda);
            }else if (waktu > 5){
                jumlahdenda = waktu * 10000;
                Console.WriteLine("Total denda : " + jumlahdenda);
            }else{
                Console.WriteLine("Tidak ada denda");
            }
            Console.ReadKey();

            
        }


    }
}
