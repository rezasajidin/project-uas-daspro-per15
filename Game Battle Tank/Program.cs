using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //inisialisasi variabel yang dibutuhkan
            int panjangRuang = 5;
            char tank = 't';
            char rumput = '~';
            char hit ='x';
            char miss = 'o';
            int jumlahTank = 3;

            char[,] playArea = buatRuang(panjangRuang, rumput, tank, jumlahTank);

            printArea(playArea, rumput, tank);

            //jumlah tank

            int jumlahTankTersembunyi = jumlahTank;

            //Gameplay
            while(jumlahTankTersembunyi>0){
                int[] tebakanKoordinat = getKoordinatTebakan(panjangRuang);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, playArea, tank, rumput, hit, miss);
                if(updateTampilanArea == hit)
                {
                    jumlahTankTersembunyi--;
                }
                playArea = updateArea (playArea, tebakanKoordinat, updateTampilanArea);
                printArea(playArea, rumput, tank);
            }

            Console.WriteLine("GameOver!!");
            Console.ReadKey();
        }

        //membuat area permainan
        static char[,] buatRuang(int panjangRuang, char rumput, char tank, int jumlahTank){
            char[,] ruangan = new char[panjangRuang, panjangRuang];
            for(int baris = 0; baris < panjangRuang; baris++)
            {
                for(int kolom = 0; kolom < panjangRuang; kolom++)
                {
                    ruangan[baris,kolom] = rumput;
                }
            }

            return letakkanTank(ruangan, jumlahTank, rumput, tank);
        }

        //meletakkan tank
        static char[,] letakkanTank(char[,] playArea, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangRuang = 5;

            while(letakTank < jumlahTank)
            {
                int[] lokasiTank = tentukanKoordinatTank(panjangRuang);
                char posisiZ = playArea[lokasiTank[0], lokasiTank[1]];

                if(posisiZ == rumput)
                {
                    playArea[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }

            return playArea;
        }

        //menentukan posisi koordinat tank (x,y)
        static int[] tentukanKoordinatTank(int panjangRuang){   
            Random rng = new Random();
            int[] koordinat = new int[2];
            for(int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rng.Next(panjangRuang);
            }

            return koordinat;            
        }

        //Prunt area
        static void printArea(char[,] playArea, char rumput, char tank){
            Console.Write("  ");
            for(int i=0; i < 5; i++)
            {
                Console.Write(i + 1 +" ");// 1 2 3 4 5
            }
            Console.WriteLine();

            for(int baris=0;baris<5; baris++)
            {
                Console.Write(baris + 1 +" ");
                for(int kolom=0; kolom < 5; kolom++)
                {
                    char posisi = playArea[baris,kolom];
                    if(posisi == tank){
                        Console.Write(rumput + " ");
                    }else{
                        Console.Write(posisi +" ");
                    }
                }
                Console.WriteLine();
            }
        }

        //Tebakan koordinat pemain
        static int[] getKoordinatTebakan(int panjangRuang){
            int baris;
            int kolom;

            do{
                Console.Write("Pilih baris : ");
                baris = Convert.ToInt32(Console.ReadLine());
            }while(baris<0 || baris>panjangRuang + 1);
            
            do{
                Console.Write("Pilih kolom : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            }while(kolom<0 || kolom>panjangRuang + 1);
            
            return new[]{baris-1,kolom-1};
        }

        //verifikasi tebakan pemain
        static char verifikasiTebakan(int[] tebakan, char[,] playArea, char tank, char rumput, char hit, char miss){

            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArea[baris,kolom];

            if(target==tank){
                pesan ="HIT!!";
                target = hit;
            }else if(target == rumput){
                pesan= "MISS!!";
                target = miss;
            }else{
                pesan = "CLEAR!!";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("----------");
            return target;
        }

        //update tampilan area
        static char[,] updateArea (char[,] playArea, int[] tebakanKoordinat, char updateTampilanArea){
            int baris = tebakanKoordinat[0];
            int kolom = tebakanKoordinat[1];
            playArea[baris,kolom] = updateTampilanArea;
            return playArea;

            
        }
    }
}