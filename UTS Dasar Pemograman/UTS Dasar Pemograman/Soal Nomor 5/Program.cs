using System;

namespace SoalNomor5UTS
{
    class Program
    {
        static bool permainanSelesai;
        static int x, y, turn, count, current, stateEnd;
        static char[] XO =new char[9];
        static int[,] posXO = new int[9,2];
        static string map = "";
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Init();

            while(count <= XO.Lenght)
            {
                Console.Clear();

                int ckxo = CekXO();
                if(ckxo != -1)
                {
                    stateEnd = ckxo;
                    permainanSelesai = true;
                }

                if(permainanSelesai)
                {
                    DrawMap();
                    if(stateEnd == 1)
                        System.Console.WriteLine("Anda kalah");
                    else if(stateEnd == 2)
                        System.Console.WriteLine("Anda menang");
                    else if(stateEnd == 0)
                        System.Console.WriteLine("Main lagi [Y], atau keluar [E]?");
                    var key = Console.ReadKey();
                    if(key.Key == ConsoleKey.Y)
                    {
                        Init();
                    }
                    else if(key.Key == ConsoleKey.N)
                    {
                        break;
                    }
                }
                else if(!permainanSelesai)
                {
                    DrawMap();
                    Console.Write("\nPilih poisi lalu tekan Enter.");
                    UpdateCurrent();
                    Console.SetCursorPosition(x,y);
                    if(turn == 0)
                    {
                        var key = Console.ReadKey();
                        if(key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                        {
                            if(current > 2)
                            current -= 3;
                        }
                        else if(key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                        {
                            if(current < 6)
                            current += 3;
                        }
                        else if(key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                        {
                            if(current > 0)
                            current--;
                        }
                        else if(key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.D)
                        {
                            if(current < 8)
                            current++;
                        } 
                        else if(key.Key == ConsoleKey.Enter)
                        {
                            if(XO[current] == ' ')
                            {
                                XO[current] = 'X';
                                UpdateCurrent();
                                posXO[current, 0] = x;
                                posXO[current, 1] = y;
                                count++;
                                turn = 1;
                            }
                        }                
                    }
                    else
                    {
                        while(turn == 1)
                        {
                            int ch = rtc.Next(9);
                            if (XO[ch] == ' ')
                            {
                                XO[ch] = 'O';
                                current = ch;
                                UpdateCurrent();
                                posXO[current, 0] = x;
                                posXO[current, 1] = y;
                                count++;
                                turn = 0;
                            }
                        }
                    }
                }   
            }
        }

        static void Init()
        {
            permainanSelesai = false;
        }

        static int CekXO()
        {

        }

        static void UpdateCurrent()
        {

        }

        static void DrawMap()
        {

        }

    }
}
