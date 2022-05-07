using System;

namespace Tic_Tac_Toe_With_AI
{
    internal class Field
    {

        public string[,] field ={ { "1", "2", "3" },
        {"4","5","6"},
        {"7","8","9" }};

        int count = 0;

        public void PrintField()
        {
            System.Console.WriteLine("     |     |  ");
            System.Console.WriteLine("  {0}  |  {1}  |  {2}   ", field[0, 0], field[0, 1], field[0, 2]);
            System.Console.WriteLine("_____|_____|_____  ");
            System.Console.WriteLine("     |     |  ");
            System.Console.WriteLine("  {0}  |  {1}  |  {2}   ", field[1, 0], field[1, 1], field[1, 2]);
            System.Console.WriteLine("_____|_____|_____  ");
            System.Console.WriteLine("     |     |  ");
            System.Console.WriteLine("  {0}  |  {1}  |  {2}   ", field[2, 0], field[2, 1], field[2, 2]);
            System.Console.WriteLine("     |     |       ");

        }



        public void SetField(bool isXOrO, int toPosiTion)
        {

            switch (toPosiTion)
            {
                case 1: field[0, 0] = isXOrO ? "X" : "O"; count++; break;
                case 2: field[0, 1] = isXOrO ? "X" : "O"; count++; break;
                case 3: field[0, 2] = isXOrO ? "X" : "O"; count++; break;
                case 4: field[1, 0] = isXOrO ? "X" : "O"; count++; break;
                case 5: field[1, 1] = isXOrO ? "X" : "O"; count++; break;
                case 6: field[1, 2] = isXOrO ? "X" : "O"; count++; break;
                case 7: field[2, 0] = isXOrO ? "X" : "O"; count++; break;
                case 8: field[2, 1] = isXOrO ? "X" : "O"; count++; break;
                case 9: field[2, 2] = isXOrO ? "X" : "O"; count++; break;

                default: System.Console.WriteLine("Out of range pleases put number 1-9"); break;
            }
        }


        public bool IsDumplicate(int toPosiTion)
        {
            switch (toPosiTion)
            {
                case 1: if (field[0, 0] == "X" || field[0, 0] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 2: if (field[0, 1] == "X" || field[0, 1] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 3: if (field[0, 2] == "X" || field[0, 2] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 4: if (field[1, 0] == "X" || field[1, 0] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 5: if (field[1, 1] == "X" || field[1, 1] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 6: if (field[1, 2] == "X" || field[1, 2] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 7: if (field[2, 0] == "X" || field[2, 0] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 8: if (field[2, 1] == "X" || field[2, 1] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;
                case 9: if (field[2, 2] == "X" || field[2, 2] == "O") { Console.WriteLine("this field was ocupied! please choose another field"); return false; } break;

                default: System.Console.WriteLine("Out of range pleases put number 1-9"); return false;
            }

            return true;
        }

        public bool IsFinish()
        {
            if (WhoWin())
            {
                return true;
            }
            else if (!WhoWin() && count == 9)
            {
                Console.Clear();
                PrintField();
                System.Console.WriteLine("DRAW!");
                return true;
            }
            return false;
        }

        private bool WhoWin()
        {

            for (int i = 0; i < 3; i++)
            {
                if (field[0, i] == "X" && field[1, i] == "X" && field[2, i] == "X" || field[i, 0] == "X" && field[i, 1] == "X" && field[i, 2] == "X")
                {
                    Console.Clear();
                    PrintField();
                    System.Console.WriteLine("X WIN!!!");
                    return true;
                }
                else if (field[0, i] == "O" && field[1, i] == "O" && field[2, i] == "O" || field[i, 0] == "O" && field[i, 1] == "O" && field[i, 2] == "O")
                {
                    Console.Clear();
                    PrintField();
                    System.Console.WriteLine("O WIN!!!");
                    return true;
                }
            }

            if (field[0, 0] == "X" && field[1, 1] == "X" && field[2, 2] == "X" || field[0, 2] == "X" && field[1, 1] == "X" && field[2, 0] == "X")
            {
                Console.Clear();
                PrintField();
                System.Console.WriteLine("X WIN!!!");
                return true;
            }
            else if (field[0, 0] == "O" && field[1, 1] == "O" && field[2, 2] == "O" || field[0, 2] == "O" && field[1, 1] == "O" && field[2, 0] == "O")
            {
                Console.Clear();
                PrintField();
                System.Console.WriteLine("O WIN!!!");
                return true;
            }
            return false;
        }


    }
}
