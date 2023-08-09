namespace B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DataParts = int.Parse(Console.ReadLine());
            for (int i = 0; i < DataParts; i++)
            {
                int TotalProducts = int.Parse(Console.ReadLine());
                int[] Prices = new int[TotalProducts];
                string[] PricesString = Console.ReadLine().Split(' ');
                for (int j = 0; j < TotalProducts; j++)
                {
                    Prices[j] = int.Parse(PricesString[j]);
                }
                PriceCalculate(Prices);
            }
        }

        static int PriceCalculate(int[] prices)
        {
            Array.Sort(prices);

        }
    }
}