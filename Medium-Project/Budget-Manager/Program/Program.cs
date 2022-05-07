using System;
using System.IO;
using System.Linq;

namespace Budget_Manager
{
    internal class Program
    {

        //===========================define Wallet class to store monney======================================
        static Wallet wallet = new Wallet();

        //=====================define string that store the directory file===============================
        static string FileDirectory = @"C:\TextFile\";

        static Catalog[] catalogs = { new Food(), new Clothes(), new Entertainment(), new Other(), new All() };
        static void Main(string[] args)
        {


            //==========================start with loop that show the interface menu the loop will break if user choose to exits the program=========================================
            int yourInput;
            while (true)
            {
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1) Add income.");
                Console.WriteLine("2) Add purchase.");
                Console.WriteLine("3) Show list of purchases.");
                Console.WriteLine("4) Balance.");
                Console.WriteLine("5) Save.");
                Console.WriteLine("6) Load.");
                Console.WriteLine("0) Exit.");

                Console.Write("Enter your input: ");
                while (!int.TryParse(Console.ReadLine(), out yourInput) || yourInput < 0 || yourInput > 6)
                {
                    Console.WriteLine("Wrong input!");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Choose your action again:.");
                    Console.WriteLine("1) Add income.");
                    Console.WriteLine("2) Add purchase.");
                    Console.WriteLine("3) Show list of purchases.");
                    Console.WriteLine("4) Balance.");
                    Console.WriteLine("5) Save.");
                    Console.WriteLine("6) Load.");
                    Console.WriteLine("0) Exit.");
                    Console.Write("Enter your input: ");

                }
                //=================================define interface fucntion for easy to read code =========================================
                Console.Clear();
                if (!userInterFace(yourInput))
                {
                    Console.WriteLine("Good bye...");
                    return;
                }

              
            }


        }


        //=================================userInterFace function ======================================================
        static bool userInterFace(int yourInput)
        {


            double incomeOrOutcome;
            switch (yourInput)
            {
                case 1:
                    Console.Write("Enter income:");
                    while (!double.TryParse(Console.ReadLine(), out incomeOrOutcome))
                    {
                        Console.WriteLine("Wrong input.");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        Console.Write("Enter income again:");
                    }
                    wallet.SetBalance(incomeOrOutcome, true);
                    Console.WriteLine("transaction success!");
                    break;

                case 2:

                    PurchaseList();
                    
                    break;

                case 3:
                    showListUserInterface();
                    break;
                case 4:
                    Console.WriteLine("Your balance is: " + wallet.ShowBalance());
                    break;
                case 5:
                    writeFile();
                    Console.WriteLine("Data saved successfully.");

                    break;
                case 6:

                    readFile();
                    Console.WriteLine("Data loaded successfully.");

                    break;
                case 0:
                    return false;
                    
            }

            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            return true;
        }

        //==============================================PurchaseList fuction============================================================
        static void PurchaseList()
        {


            int yourinput;
            while (true)
            {
                Console.WriteLine("Choose the type of purchase.");
                Console.WriteLine("1) Food.");
                Console.WriteLine("2) Clothes.");
                Console.WriteLine("3) Entertainment.");
                Console.WriteLine("4) Other.");
                Console.WriteLine("5) Back.");
                Console.Write("Enter your input: ");
                while (!int.TryParse(Console.ReadLine(), out yourinput) || yourinput < 1 || yourinput > 5)
                {

                    Console.WriteLine("Wrong input.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Choose the type of purchase again.");
                    Console.WriteLine("1) Food.");
                    Console.WriteLine("2) Clothes.");
                    Console.WriteLine("3) Entertainment.");
                    Console.WriteLine("4) Other.");
                    Console.WriteLine("5) Back.");
                    Console.Write("Enter your input: ");
                }

                int product = -1;
                string detail = "";
                double price;

                switch (yourinput)
                {

                    case 1:
                        product = 0;

                        break;
                    case 2:
                        product = 1;
                        break;
                    case 3:
                        product = 2;

                        break;
                    case 4:
                        product = 3;
                        break;
                    case 5:
                        Console.WriteLine("Back to menu...");
                        return;

                }              
                Console.Clear();
                Console.WriteLine("Enter purchase name:");
                detail = Console.ReadLine();
                Console.WriteLine("Enter its price:");
                while (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("Wrong input");

                    Console.WriteLine("Enter its price again:");
                }

                if (wallet.GetBalance() < price)
                {
                    Console.WriteLine("don't have enough money.");
                    continue;
                }
                else
                {
                    catalogs[product].AddPurchase(detail, price);
                    //================ this is All class=================
                    catalogs[4].AddPurchase(detail, price);
                    wallet.SetBalance(price, false);
                    Console.WriteLine("transaction success!");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }

            }
        }

        //===================================showListUserInterface function=========================================================
        static void showListUserInterface()
        {
            int yourinput;
            while (true)
            {
                Console.WriteLine("Choose the type of List.");
                Console.WriteLine("1) Food.");
                Console.WriteLine("2) Clothes.");
                Console.WriteLine("3) Entertainment.");
                Console.WriteLine("4) Other.");
                Console.WriteLine("5) All.");
                Console.WriteLine("6) Back.");
                Console.Write("Enter your input: ");
                while (!int.TryParse(Console.ReadLine(), out yourinput) || yourinput < 1 || yourinput > 6)
                {

                    Console.WriteLine("Wrong input.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Choose the type of purchase again.");
                    Console.WriteLine("1) Food.");
                    Console.WriteLine("2) Clothes.");
                    Console.WriteLine("3) Entertainment.");
                    Console.WriteLine("4) Other.");
                    Console.WriteLine("5) All.");
                    Console.WriteLine("6) Back.");
                    Console.Write("Enter your input: ");
                }
                Console.Clear();
                int product = -1;
                switch (yourinput)
                {

                    case 1:
                        product = 0;

                        break;
                    case 2:
                        product = 1;
                        break;
                    case 3:
                        product = 2;

                        break;
                    case 4:
                        product = 3;
                        break;
                    case 5:
                        product = 4;
                        break;
                    case 6:
                        Console.WriteLine("Back to menu...");
                        return;

                }

                catalogs[product].showList();
                Console.WriteLine("Enter for back to menu....");
                Console.ReadKey();
                Console.Clear();


            }

        }

        //=============================FileWriter Function===============================================
        static void writeFile()
        {
            File.WriteAllText(FileDirectory + "MyWallet.txt", wallet.GetBalance().ToString());
            File.WriteAllLines(FileDirectory + "Food.txt", catalogs[0].Product.Select(x => "[" + x.Key + "=" + x.Value + "]").ToArray());
            File.WriteAllLines(FileDirectory + "Clothes.txt", catalogs[1].Product.Select(x => "[" + x.Key + "=" + x.Value + "]").ToArray());
            File.WriteAllLines(FileDirectory + "Entertainment.txt", catalogs[2].Product.Select(x => "[" + x.Key + "=" + x.Value + "]").ToArray());
            File.WriteAllLines(FileDirectory + "Other.txt", catalogs[3].Product.Select(x => "[" + x.Key + "=" + x.Value + "]").ToArray());
            File.WriteAllLines(FileDirectory + "ALL.txt", catalogs[4].Product.Select(x => "[" + x.Key + "=" + x.Value + "]").ToArray());
        }

        //=============================FileReadter Function===============================================
        static void readFile()
        {
            string[] readFile = File.ReadAllLines(FileDirectory + "MyWallet.txt");
            wallet.SetBalance(double.Parse(readFile[0]));


            char[] charsToTrim = { '[', ']', ' ' };
            catalogs[0].Product = File.ReadAllLines(FileDirectory + "Food.txt")
                                         .Select(x => x.Split('='))
                                        .ToDictionary(x => x[0].Trim(charsToTrim), x => double.Parse(x[1].Trim(charsToTrim)));
            catalogs[1].Product = File.ReadAllLines(FileDirectory + "Clothes.txt")
                                        .Select(x => x.Split('='))
                                        .ToDictionary(x => x[0].Trim(charsToTrim), x => double.Parse(x[1].Trim(charsToTrim)));
            catalogs[2].Product = File.ReadAllLines(FileDirectory + "Entertainment.txt")
                                         .Select(x => x.Split('='))
                                        .ToDictionary(x => x[0].Trim(charsToTrim), x => double.Parse(x[1].Trim(charsToTrim)));
            catalogs[3].Product = File.ReadAllLines(FileDirectory + "Other.txt")
                                          .Select(x => x.Split('='))
                                        .ToDictionary(x => x[0].Trim(charsToTrim), x => double.Parse(x[1].Trim(charsToTrim)));
            catalogs[4].Product = File.ReadAllLines(FileDirectory + "ALL.txt")
                                        .Select(x => x.Split('='))
                                        .ToDictionary(x => x[0].Trim(charsToTrim), x => double.Parse(x[1].Trim(charsToTrim)));


        }
    }
}








