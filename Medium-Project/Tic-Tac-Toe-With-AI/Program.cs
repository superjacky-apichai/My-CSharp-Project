using System;

namespace Tic_Tac_Toe_With_AI
{
    internal class Program
    {
        //create the field and player object
        static Player player1;
        static Player player2;
        static Field field = new Field();

        static void Main(string[] args)
        {

            //fisrt loop for reset the game and exits game
            while (true)
            {
                Console.Clear();

                field = new Field();
                //this array value assinge frome interfaceForChooseUser function
                int[] player = interfaceForChooseUser();
                //this fucntion assinge value of object player1 and object player 2
                ChooseUser(player);
                bool turnChecker = true;

                System.Threading.Thread.Sleep(1000);

                //second loop for check if game Ain't Over Yet this loop still continue
                while (!field.IsFinish())
                {

                    field.PrintField();

                    if (turnChecker)
                    {
                        Console.Write("User X Enter your field: ");
                        int setPosition = player1.SetPosition();
                        while (!field.IsDumplicate(setPosition) || (setPosition < 1 || setPosition > 9))
                        {
                            Console.Write("User X Enter your field again: ");
                            setPosition = player1.SetPosition();
                        }

                        field.SetField(true, setPosition);
                        turnChecker = false;
                    }
                    else if (!turnChecker)
                    {
                        Console.Write("User O Enter your field: ");
                        int setPosition = player2.SetPosition();

                        while (!field.IsDumplicate(setPosition) || (setPosition < 1 || setPosition > 9))
                        {

                            Console.Write("User O Enter your field again: ");
                            setPosition = player2.SetPosition();
                        }
                        field.SetField(false, setPosition);

                        turnChecker = true;
                    }

                    if (field.IsFinish())
                    {

                        System.Threading.Thread.Sleep(5000);
                    }
                    Console.Clear();

                }


                Console.Clear();

                Console.WriteLine("Reset the game or exits the programe?");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("1.Reset the game!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("2.Exits the program!");
                System.Threading.Thread.Sleep(1000);
                Console.Write("Enter your input: ");
                int resetOrExit = 0;
                while (!int.TryParse(Console.ReadLine(), out resetOrExit) || resetOrExit < 0 || resetOrExit > 2)
                {

                    if (resetOrExit < 0 || resetOrExit > 2)
                    {
                        Console.WriteLine("Please enter number in range 1 - 2!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong input.");
                    }

                }

                if (resetOrExit == 1)
                {

                    continue;
                }
                else
                {
                    break;
                }

            }









        }


        //Method for start menu game
        public static int[] interfaceForChooseUser()
        {
            //create interface menu game player choose
            Console.WriteLine("Welcome to Tic-Tac-Toe!!!");

            System.Threading.Thread.Sleep(1000);

            //Let X player choose the user.
            Console.WriteLine("Choose for user X");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1.For Player");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2.For AI-Easy");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3.For AI-Medium");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4.For AI-Hard");
            System.Threading.Thread.Sleep(1000);


            //made input for user X
            int inputUserX = 0;
            Console.Write("Enter your input: ");
            while (!int.TryParse(Console.ReadLine(), out inputUserX) || (inputUserX > 4 || inputUserX < 1))
            {
                if ((inputUserX > 4 || inputUserX < 1))
                {
                    Console.WriteLine("please enter number in range 1 - 4");
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
                Console.Write("Enter your input: ");
            }

            switch (inputUserX)
            {
                case 1: Console.WriteLine("User X choose player!"); break;
                case 2: Console.WriteLine("User X choose AI-Easy!"); break;
                case 3: Console.WriteLine("User X choose AI-Medium!"); break;
                case 4: Console.WriteLine("User X choose AI-Hard!"); break;
            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            //Let O player choose the user.
            Console.WriteLine("Choose for user O");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1.For Player");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2.For AI-Easy");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3.For AI-Medium");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4.For AI-Hard");
            System.Threading.Thread.Sleep(1000);


            //made input for user O
            int inputUserO = 0;
            Console.Write("Enter your input: ");
            while (!int.TryParse(Console.ReadLine(), out inputUserO) || (inputUserO > 4 || inputUserO < 1))
            {

                if ((inputUserO > 4 || inputUserO < 1))
                {
                    Console.WriteLine("please enter number in range 1 - 4");
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
                Console.Write("Enter your input: ");
            }

            switch (inputUserO)
            {
                case 1: Console.WriteLine("User O choose player!"); break;
                case 2: Console.WriteLine("User O choose AI-Easy!"); break;
                case 3: Console.WriteLine("User O choose AI-Medium!"); break;
                case 4: Console.WriteLine("User O choose AI-Hard!"); break;
            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            //return array for value of user x and o 
            return new int[] { inputUserX, inputUserO };
        }



        //Use Polymorphic Parameters to define user
        public static void ChooseUser(int[] player)
        {


            switch (player[0])
            {
                case 1: player1 = new Player(); break;
                case 2: player1 = new AI_Easy(); break;
                case 3: player1 = new AI_Medium(field, true); break;
                case 4: player1 = new AI_Hard(field, true); break;
            }

            switch (player[1])
            {
                case 1: player2 = new Player(); break;
                case 2: player2 = new AI_Easy(); break;
                case 3: player2 = new AI_Medium(field, false); break;
                case 4: player2 = new AI_Hard(field, false); break;
            }
        }
    }
}
