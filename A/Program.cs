namespace A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DataParts = int.Parse(Console.ReadLine());

            for (int i = 0; i < DataParts; i++)
            {
                string[] StringNumbers = Console.ReadLine().Split(' ');
                int FirstNumber = int.Parse(StringNumbers[0]);
                int SecondNumber = int.Parse(StringNumbers[1]);
                Console.WriteLine(Add(FirstNumber, SecondNumber));
            }
        }

        static int Add(int x, int y) => x + y;
    }
}