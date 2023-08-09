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

        static void PriceCalculate(int[] prices)
        {
            Array.Sort(prices);

            int TotalCounter = prices[0];
            int ProductCounter = 2;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] == prices[i - 1] && ProductCounter != 3)
                {
                    ProductCounter++;
                    TotalCounter += prices[i];
                }
                else if (prices[i] == prices[i - 1] && ProductCounter == 3)
                {
                    ProductCounter = 1;
                    continue;
                }
                else
                {
                    TotalCounter += prices[i];
                    ProductCounter = 2;
                }
            }
            Console.WriteLine(TotalCounter);
        }
    }
}