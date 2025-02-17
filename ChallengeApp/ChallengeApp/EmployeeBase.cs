namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public virtual void AddGrade(long grade)
        {
            float longInFloat = (float)grade;
            this.AddGrade(longInFloat);
        }

        public virtual void AddGrade(double grade)
        {
            float doubleInFloat = (float)grade;
            this.AddGrade(doubleInFloat);
        }

        public virtual void AddGrade(int grade)
        {
            float intInFloat = (float)grade;
            this.AddGrade(intInFloat);
        }

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}
