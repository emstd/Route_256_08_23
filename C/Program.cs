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
                List<int> Skills = new List<int>();
                string[] SkillsString = Console.ReadLine().Split(' ');
                for (int j = 0; j < SkillsString.Length; j++)
                {
                    Skills.Add(int.Parse(SkillsString[j]));
                }
                Grouping(Skills);
            }
        }

        static void Grouping(List<int> skills)
        {
            if (skills.Count == 2)
            {
                Console.WriteLine("1 2");
                return;
            }

            int Position = 0;
            int Subtraction = 0;
            int ResultSubtraction = 0;

            for (int i = 0; i < skills.Count; i++)
            {
                for (int j = 1; j < skills.Count; j++)
                {
                    if (i == 0 && j == 1)
                    {
                        ResultSubtraction = Math.Abs(skills[i] - skills[j]);
                        continue;
                    }


                    Subtraction = Math.Abs(skills[i] - skills[j]);

                    if (Subtraction < ResultSubtraction)
                    {
                        Position = j + 1;
                        ResultSubtraction = Subtraction;
                    }


                    ResultSubtraction = Math.Abs(skills[i] - skills[j]);
                }
            }
        }
    }
}