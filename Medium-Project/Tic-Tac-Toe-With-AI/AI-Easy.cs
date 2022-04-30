using System;

namespace Tic_Tac_Toe_With_AI
{

    //class for AI easy just random some int
    internal class AI_Easy : Player
    {


        public override int SetPosition()
        {
            System.Threading.Thread.Sleep(1000);
            Random random = new Random();
            int output = random.Next(1, 10);
            return output;
        }
    }
}
