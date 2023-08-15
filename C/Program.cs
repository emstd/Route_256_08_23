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

            var Developers = skills.Select((dev, index) => new Developer(index + 1, dev)).ToList();

            if (Developers.Count == 2)
            {
                Console.WriteLine("1 2");
                return;
            }


            int Position = 0;
            int Subtraction = 0;
            int ResultSubtraction = 0;

            for (int i = 0; Developers.Count > 0;)
            {
                ResultSubtraction = Math.Abs(Developers[i].Skill - Developers[i + 1].Skill);
                Position = i + 1;
                for(int j = 1; j < Developers.Count; j++)
                {
                    Subtraction = Math.Abs(Developers[i].Skill - Developers[j].Skill);
                    if (Subtraction < ResultSubtraction)
                    {
                        ResultSubtraction = Subtraction;
                        Position = j;
                    }
                    if (j == Developers.Count - 1)
                    {
                        Console.WriteLine(Developers[i].id + " " + Developers[Position].id);
                        Developers.RemoveAt(i);
                        Developers.RemoveAt(Position - 1);
                    }
                }
            }
        }
    }

    public class Developer
    {
        public Developer(int Id, int skill)
        {
            id = Id;
            Skill = skill;
        }
        public int id { get; set; }
        public int Skill { get; set; }
    }
}