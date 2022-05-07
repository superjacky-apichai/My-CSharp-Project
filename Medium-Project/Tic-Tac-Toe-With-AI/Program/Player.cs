using System;

namespace Tic_Tac_Toe_With_AI
{
    public class Player : UserInterface
    {


        //this class use for Polymorphic to other class and main class for player user
        public int SetPosition()
        {
            int toPosition;

            while (!int.TryParse(Console.ReadLine(), out toPosition) && (toPosition < 1 || toPosition > 9))
            {
                Console.WriteLine("Wrong input!");
            }
            return toPosition;
        }




    }
}
