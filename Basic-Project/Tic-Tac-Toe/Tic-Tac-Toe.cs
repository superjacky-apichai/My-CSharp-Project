using System;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static string[,] field = // create field for playing game
           {
            {"1","2","3" }, // row 1
            {"4","5","6"},// row 2
            {"7","8","9"}// row 3

        };

        static string[,] forResetField = // create field for backup if game is over
         {
            {"1","2","3" }, // row 1
            {"4","5","6"},// row 2
            {"7","8","9"}// row 3

        };

        static int count = 0; //check loop if player choose all field


        static void Main(string[] args)
        {
            //player variable for check player1 turn or player 2 turn
            int player = 2;

            //input variable for input position in field for player to occupie
            int input = 0;

            // this loop for reset or exit program if game is over
            while (true)
            {
                printField(); //printField function for output OX play field
                player = 2; //set player to 2 every time we start the game

                do // this loop for continue the game if the game still don't over yet and change player turn
                {


                    //set player who will pick the field this turn 
                    if (player == 1)
                    {
                        player = 2;
                    }
                    else if (player == 2)
                    {
                        player = 1;
                    }


                    do//this loop for check is correct input if wrong input the loop will continue 
                    {
                        Console.Write("Player {0}: Choose your field! ", player); //output who will choose field in this turn 
                        if (int.TryParse(Console.ReadLine(), out input) && isOccupied(input))//conditon if correct input or wrong input and this check player choose dumplicate field
                        {



                            if (input < 1 || input > 9) //this wrong input if input number less than 1 or great than 9
                            {
                                Console.WriteLine("Pleases enter number in range 1-9");
                            }
                            else
                            {
                                //this condition will set the field if input correctly and break the check input loop
                                putXO(player, input);
                                count++;//cout the field
                                Console.WriteLine("you occupied this channel!!");
                                Console.WriteLine();
                                break;
                            }






                        }
                        else//this condition will active if wrong input or field that player choose  has occupied
                        {
                            if (!isOccupied(input))//this conditoin will active if field that player choose  has occupied
                            {

                                Console.WriteLine("This channel has been occupied!!");

                            }
                            else // this conditoin will active if this condition will active if wrong input 
                            {
                                Console.WriteLine("Wrong input!!");
                            }

                        }

                    } while (true);//use while true cuase need 1 condition to break this loop isit's correct input




                } while (!checkWinner());//check is game over yet is over this loop will break

                int choice = 0; //choice variable to set condition reset game or exit the program

                while (true)//this loop will check input correct or wrong input if it wrong loop will continue else loop will break
                {
                    Console.WriteLine("enter key for reset or exit field"); //out put to tell user input the choice
                    Console.WriteLine("1.For reset");
                    Console.WriteLine("2.For exit");

                    if (int.TryParse(Console.ReadLine(), out choice)) //this condition will active if input correct 
                    {

                        if (choice < 1 || choice > 2)//this condition will check even correct input but are they still in range
                        {
                            Console.WriteLine("out of range pleases enter number in rang 1 - 2");
                            continue;
                        }

                        break;

                    }
                    else//this condition will active if it wrong input
                    {
                        Console.WriteLine("Wrong input!!");
                        continue;
                    }




                }


                //this condition will manage the program will reset or it will exit
                if (choice == 1)
                {
                    field = forResetField;
                    count = 0;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Good bye!!!");
                    break;
                }


            }

        }



        //this function use to print the field
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

        //this function use to check the field player choose has occupied or not
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


        //this function set field player choose turn into X or O 
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

        //this function check who will win in the game
        static bool checkWinner()
        {
            printField();

            if ((field[0, 0] == "X" && field[1, 1] == "X" && field[2, 2] == "X") || (field[0, 2] == "X" && field[1, 1] == "X" && field[2, 0] == "X"))
            {
                Console.WriteLine("X WIN!!!");
                return true;
            }
            else if ((field[0, 0] == "O" && field[1, 1] == "O" && field[2, 2] == "O") || (field[0, 2] == "O" && field[1, 1] == "O" && field[2, 0] == "O"))
            {
                Console.WriteLine("O WIN!!!");
                return true;
            }




            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if ((field[i, 0] == "X" && field[i, 1] == "X" && field[i, 2] == "X") || (field[0, j] == "X" && field[1, j] == "X" && field[2, j] == "X"))
                    {
                        Console.WriteLine("X WIN!!!");
                        return true;
                    }
                    else if ((field[i, 0] == "O" && field[i, 1] == "O" && field[i, 2] == "O") || (field[0, j] == "O" && field[1, j] == "O" && field[2, j] == "O"))
                    {
                        Console.WriteLine("O WIN!!!");
                        return true;
                    }

                }
            }

            if (count == 9)
            {
                Console.WriteLine("DRAW!!!");
                return true;
            }

            return false;
        }

    }
}
