using System;

namespace Tic_Tac_Toe_With_AI
{
    internal class AI_Medium : Player
    {
        Field Field;
        bool XOrO;

        public AI_Medium(Field field, bool xOrO)
        {
            Field = field;
            XOrO = xOrO;
        }
        public override int SetPosition()
        {
            System.Threading.Thread.Sleep(1000);
            if (XOrO)
            {

                //Row 1
                if ((Field.field[0, 0] == "O" && Field.field[0, 1] == "O" && Field.field[0, 2] == "3"))
                {
                    return 3;
                }
                else if ((Field.field[0, 0] == "O" && Field.field[0, 2] == "O" && Field.field[0, 1] == "2"))
                {
                    return 2;
                }
                else if ((Field.field[0, 0] == "1" && Field.field[0, 2] == "O" && Field.field[0, 1] == "O"))
                {
                    return 1;
                }
                //Row 2
                else if ((Field.field[1, 0] == "O" && Field.field[1, 1] == "O" && Field.field[1, 2] == "6"))
                {
                    return 6;
                }
                else if ((Field.field[1, 0] == "O" && Field.field[1, 2] == "O" && Field.field[1, 1] == "5"))
                {
                    return 5;
                }
                else if ((Field.field[1, 0] == "4" && Field.field[1, 2] == "O" && Field.field[1, 1] == "O"))
                {
                    return 4;
                }

                //Row 3
                else if ((Field.field[2, 0] == "O" && Field.field[2, 1] == "O" && Field.field[2, 2] == "9"))
                {
                    return 9;
                }
                else if ((Field.field[2, 0] == "O" && Field.field[2, 2] == "O" && Field.field[2, 1] == "8"))
                {
                    return 8;
                }
                else if ((Field.field[2, 0] == "7" && Field.field[2, 2] == "O" && Field.field[2, 1] == "O"))
                {
                    return 7;
                }

                //Colum 1
                else if ((Field.field[0, 0] == "O" && Field.field[1, 0] == "O" && Field.field[2, 0] == "7"))
                {
                    return 7;
                }
                else if ((Field.field[0, 0] == "O" && Field.field[1, 0] == "4" && Field.field[0, 1] == "O"))
                {
                    return 4;
                }
                else if ((Field.field[0, 0] == "1" && Field.field[1, 0] == "O" && Field.field[1, 0] == "O"))
                {
                    return 1;
                }

                //Colum 2
                else if ((Field.field[0, 1] == "O" && Field.field[1, 1] == "O" && Field.field[2, 1] == "8"))
                {
                    return 8;
                }
                else if ((Field.field[0, 1] == "O" && Field.field[1, 1] == "5" && Field.field[2, 1] == "O"))
                {
                    return 5;
                }
                else if ((Field.field[0, 1] == "2" && Field.field[1, 1] == "O" && Field.field[2, 1] == "O"))
                {
                    return 2;
                }

                //Colum 3
                else if ((Field.field[0, 2] == "O" && Field.field[1, 2] == "O" && Field.field[2, 2] == "9"))
                {
                    return 9;
                }
                else if ((Field.field[0, 2] == "O" && Field.field[1, 2] == "6" && Field.field[2, 2] == "O"))
                {
                    return 6;
                }
                else if ((Field.field[0, 2] == "3" && Field.field[1, 2] == "O" && Field.field[2, 2] == "O"))
                {
                    return 3;
                }

                //Diagonal 1
                else if ((Field.field[0, 0] == "O" && Field.field[1, 1] == "O" && Field.field[2, 2] == "9"))
                {
                    return 9;
                }
                else if ((Field.field[0, 0] == "O" && Field.field[1, 1] == "5" && Field.field[2, 2] == "O"))
                {
                    return 5;
                }
                else if ((Field.field[0, 0] == "1" && Field.field[1, 1] == "O" && Field.field[2, 2] == "O"))
                {
                    return 1;
                }

                //Diagonal 2
                else if ((Field.field[0, 2] == "O" && Field.field[1, 1] == "O" && Field.field[2, 0] == "7"))
                {
                    return 7;
                }
                else if ((Field.field[0, 2] == "O" && Field.field[1, 1] == "5" && Field.field[2, 0] == "O"))
                {
                    return 5;
                }
                else if ((Field.field[0, 2] == "3" && Field.field[1, 1] == "O" && Field.field[2, 0] == "O"))
                {
                    return 3;
                }



            }
            else if (!XOrO)
            {

                //Row 1
                if ((Field.field[0, 0] == "X" && Field.field[0, 1] == "X" && Field.field[0, 2] == "3"))
                {
                    return 3;
                }
                else if ((Field.field[0, 0] == "X" && Field.field[0, 2] == "X" && Field.field[0, 1] == "2"))
                {
                    return 2;
                }
                else if ((Field.field[0, 0] == "1" && Field.field[0, 2] == "X" && Field.field[0, 1] == "X"))
                {
                    return 1;
                }
                //Row 2
                else if ((Field.field[1, 0] == "X" && Field.field[1, 1] == "X" && Field.field[1, 2] == "6"))
                {
                    return 6;
                }
                else if ((Field.field[1, 0] == "X" && Field.field[1, 2] == "X" && Field.field[1, 1] == "5"))
                {
                    return 5;
                }
                else if ((Field.field[1, 0] == "4" && Field.field[1, 2] == "X" && Field.field[1, 1] == "X"))
                {
                    return 4;
                }

                //Row 3
                else if ((Field.field[2, 0] == "X" && Field.field[2, 1] == "X" && Field.field[2, 2] == "9"))
                {
                    return 9;
                }
                else if ((Field.field[2, 0] == "X" && Field.field[2, 2] == "X" && Field.field[2, 1] == "8"))
                {
                    return 8;
                }
                else if ((Field.field[2, 0] == "7" && Field.field[2, 2] == "X" && Field.field[2, 1] == "X"))
                {
                    return 7;
                }

                //Colum 1
                else if ((Field.field[0, 0] == "X" && Field.field[1, 0] == "X" && Field.field[2, 0] == "7"))
                {
                    return 7;
                }
                else if ((Field.field[0, 0] == "X" && Field.field[1, 0] == "4" && Field.field[0, 1] == "X"))
                {
                    return 4;
                }
                else if ((Field.field[0, 0] == "1" && Field.field[1, 0] == "X" && Field.field[1, 0] == "X"))
                {
                    return 1;
                }

                //Colum 2
                else if ((Field.field[0, 1] == "X" && Field.field[1, 1] == "X" && Field.field[2, 1] == "8"))
                {
                    return 8;
                }
                else if ((Field.field[0, 1] == "X" && Field.field[1, 1] == "5" && Field.field[2, 1] == "X"))
                {
                    return 5;
                }
                else if ((Field.field[0, 1] == "2" && Field.field[1, 1] == "X" && Field.field[2, 1] == "X"))
                {
                    return 2;
                }

                //Colum 3
                else if ((Field.field[0, 2] == "X" && Field.field[1, 2] == "X" && Field.field[2, 2] == "9"))
                {
                    return 9;
                }
                else if ((Field.field[0, 2] == "X" && Field.field[1, 2] == "6" && Field.field[2, 2] == "X"))
                {
                    return 6;
                }
                else if ((Field.field[0, 2] == "3" && Field.field[1, 2] == "X" && Field.field[2, 2] == "X"))
                {
                    return 3;
                }

                //Diagonal 1
                else if ((Field.field[0, 0] == "X" && Field.field[1, 1] == "X" && Field.field[2, 2] == "9"))
                {
                    return 9;
                }
                else if ((Field.field[0, 0] == "X" && Field.field[1, 1] == "5" && Field.field[2, 2] == "X"))
                {
                    return 5;
                }
                else if ((Field.field[0, 0] == "1" && Field.field[1, 1] == "X" && Field.field[2, 2] == "X"))
                {
                    return 1;
                }

                //Diagonal 2
                else if ((Field.field[0, 2] == "X" && Field.field[1, 1] == "X" && Field.field[2, 0] == "7"))
                {
                    return 7;
                }
                else if ((Field.field[0, 2] == "X" && Field.field[1, 1] == "5" && Field.field[2, 0] == "X"))
                {
                    return 5;
                }
                else if ((Field.field[0, 2] == "3" && Field.field[1, 1] == "X" && Field.field[2, 0] == "X"))
                {
                    return 3;
                }

            }

            Random random = new Random();
            int output = random.Next(1, 10);
            return output;

        }
    }
}
