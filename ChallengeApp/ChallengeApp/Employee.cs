namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = name;
        }

        private List<float> grades = new List<float>();

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statisctics.Max = Math.Max(statisctics.Max, grade);
                statisctics.Min = Math.Min(statisctics.Min, grade);
                statisctics.Average += grade;
            }

            statisctics.Average /= this.grades.Count;

            return statisctics;
        }

    }
}
