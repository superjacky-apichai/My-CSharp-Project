namespace Budget_Manager
{
    internal class Wallet
    {
        double MyBalance = 0;

        public void SetBalance(double howMuch, bool saveOrPurchase)
        {

            if (saveOrPurchase)
            {
                this.MyBalance += howMuch;

            }
            else if (!saveOrPurchase)
            {
                this.MyBalance -= howMuch;

            }


        }


        public void SetBalance(double howMuch)
        {

            this.MyBalance = howMuch;

        }

        public double GetBalance()
        {

            return MyBalance;

        }
        public string ShowBalance()
        {
            return $"${MyBalance:N}";
        }

    }
}
