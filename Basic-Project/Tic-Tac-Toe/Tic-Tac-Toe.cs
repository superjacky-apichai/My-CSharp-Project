using System;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static string[,] field =
           {
            {"1","2","3" },
            {"4","5","6"},
            {"7","8","9"}

        };

        static void Main(string[] args)
        {

            int player = 2;
            int input = 0;




            do
            {
                printField();
                if (player == 1)
                {
                    player = 2;
                }
                else if (player == 2)
                {
                    player = 1;
                }


                do
                {
                    Console.Write("Player {0}: Choose your field! ", player);
                    if (int.TryParse(Console.ReadLine(), out input) && isOccupied(input))
                    {



                        if (input < 1 || input > 9)
                        {
                            Console.WriteLine("Pleases enter number in range 1-9");
                        }
                        else
                        {
                            putXO(player, input);
                            Console.WriteLine("you occupied this channel!!");
                            Console.WriteLine();
                            break;
                        }






                    }
                    else
                    {
                        if (!isOccupied(input))
                        {

                            Console.WriteLine("This channel has been occupied!!");

                        }
                        else
                        {
                            Console.WriteLine("Wrong input!!");
                        }

                    }

                } while (true);




            } while (!checkWinner());



            Console.Read();
        }



        static void printField()
        {
            Console.Clear();
            Console.WriteLine("\n    |     |     " +
                              "\n  {0} |  {1}  |  {2} " +
                              "\n____|_____|_____" +
                              "\n    |     |     " +
                              "\n  {3} |  {4}  |  {5} " +
                              "\n____|_____|_____" +
                              "\n    |     |     " +
                              "\n  {6} |  {7}  |  {8} " +
                              "\n    |     |     "
                               , field[0, 0], field[0, 1], field[0, 2]
                               , field[1, 0], field[1, 1], field[1, 2]
                               , field[2, 0], field[2, 1], field[2, 2]);
        }


        public static bool isOccupied(int input)
        {
            bool checker = true;
            switch (input)
            {

                case 1: if (field[0, 0] != "1") checker = false; break;
                case 2: if (field[0, 1] != "2") checker = false; break;
                case 3: if (field[0, 2] != "3") checker = false; break;
                case 4: if (field[1, 0] != "4") checker = false; break;
                case 5: if (field[1, 1] != "5") checker = false; break;
                case 6: if (field[1, 2] != "6") checker = false; break;
                case 7: if (field[2, 0] != "7") checker = false; break;
                case 8: if (field[2, 1] != "8") checker = false; break;
                case 9: if (field[2, 2] != "9") checker = false; break;

                default: break;

            }

            if (!checker)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        static void putXO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
            {
                playerSign = 'X';
            }
            else if (player == 2)
            {
                playerSign = 'O';
            }

            switch (input)
            {

                case 1: field[0, 0] = playerSign.ToString(); break;
                case 2: field[0, 1] = playerSign.ToString(); break;
                case 3: field[0, 2] = playerSign.ToString(); break;
                case 4: field[1, 0] = playerSign.ToString(); break;
                case 5: field[1, 1] = playerSign.ToString(); break;
                case 6: field[1, 2] = playerSign.ToString(); break;
                case 7: field[2, 0] = playerSign.ToString(); break;
                case 8: field[2, 1] = playerSign.ToString(); break;
                case 9: field[2, 2] = playerSign.ToString(); break;
                default: break;

            }



        }

        static bool checkWinner()
        {


            if (field[0, 0] == "X" && field[1, 1] == "X" && field[2, 2] == "X")
            {
                Console.WriteLine("X WIN");
                return true;
            }
            else if (field[0, 0] == "O" && field[1, 1] == "O" && field[2, 2] == "O")
            {
                Console.WriteLine("O WIN");
                return true;
            }
            else if (field[0, 2] == "X" && field[1, 1] == "X" && field[2, 0] == "X")
            {
                Console.WriteLine("X WIN");
                return true;
            }
            else if (field[0, 2] == "O" && field[1, 1] == "O" && field[2, 0] == "O")
            {
                Console.WriteLine("O WIN");
                return true;
            }



            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, 0] == "X" && field[i, 1] == "X" && field[i, 2] == "X")
                    {
                        Console.WriteLine("X WIN");
                        return true;
                    }
                    else if (field[i, 0] == "O" && field[i, 1] == "O" && field[i, 2] == "O")
                    {
                        Console.WriteLine("O WIN");
                        return true;
                    }
                    else if (field[0, j] == "X" && field[1, j] == "X" && field[2, j] == "X")
                    {
                        Console.WriteLine("X WIN");
                        return true;
                    }
                    else if (field[0, j] == "O" && field[1, j] == "O" && field[2, j] == "O")
                    {
                        Console.WriteLine("O WIN");
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
