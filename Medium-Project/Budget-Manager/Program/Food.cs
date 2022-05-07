namespace Budget_Manager
{
    internal class Food : Catalog
    {

        public override void AddPurchase(string product, double price)
        {
            base.AddPurchase(product, price);
        }
        public override void showList()
        {
            System.Console.WriteLine("Food:");
            base.showList();
        }
    }
}
