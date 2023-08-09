namespace C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DataParts = int.Parse(Console.ReadLine());

            for (int i = 0; i < DataParts; i++)
            {
                int TotalProgrammers = int.Parse(Console.ReadLine());
                int[] Skills = new int[TotalProgrammers];
                string[] SkillsString = Console.ReadLine().Split(' ');
                for (int j = 0; j < SkillsString.Length; j++)
                {
                    Skills[j] = int.Parse(SkillsString[j]);
                }
                Grouping(Skills);
            }
        }

        static void Grouping(int[] skills)
        {

        }

    }
}