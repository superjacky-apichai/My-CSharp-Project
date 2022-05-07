namespace Budget_Manager
{
    internal class Other : Catalog
    {
        public override void AddPurchase(string product, double price)
        {
            base.AddPurchase(product, price);
        }

        public override void showList()
        {
            System.Console.WriteLine("Other:");
            base.showList();
        }
    }
}
