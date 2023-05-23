using System.Diagnostics;

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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }
        }

        public void AddGrade(long grade)
        {
            float longInFloat = (float)grade;
            this.AddGrade(longInFloat);
        }

        public void AddGrade(double grade)
        {
            float doubleInFloat = (float)grade;
            this.AddGrade(doubleInFloat);
        }

        public void AddGrade(int grade)
        {
            float intInFloat = (float)grade;
            this.AddGrade(intInFloat);
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statisctics.Max = Math.Max(statisctics.Max, this.grades[index]);
                statisctics.Min = Math.Min(statisctics.Min, this.grades[index]);
                statisctics.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            statisctics.Average /= this.grades.Count;

            return statisctics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statisctics.Max = Math.Max(statisctics.Max, this.grades[index]);
                statisctics.Min = Math.Min(statisctics.Min, this.grades[index]);
                statisctics.Average += this.grades[index];
                index++;
            }

            statisctics.Average /= this.grades.Count;

            return statisctics;

        }

        public Statistics GetStatisticsWithForEach()
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

        public Statistics GetStatisticsWithFor()
        {
            var statisctics = new Statistics();
            statisctics.Average = 0;
            statisctics.Max = float.MinValue;
            statisctics.Min = float.MaxValue;

            for (var i = 0; i < this.grades.Count; i++)
            {
                statisctics.Max = Math.Max(statisctics.Max, this.grades[i]);
                statisctics.Min = Math.Min(statisctics.Min, this.grades[i]);
                statisctics.Average += this.grades[i];
            }

            statisctics.Average /= this.grades.Count;

            return statisctics;

        }

    }
}
