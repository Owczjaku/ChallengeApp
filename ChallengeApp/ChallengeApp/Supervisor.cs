namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            float result = (float)grade;
            this.grades.Add(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.grades.Add(result);
        }

        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.grades.Add(result);
        }

        public void AddGrade(char grade)
        {
            float result = (float)grade;
            this.grades.Add(result);
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(160);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(150);
                    break;
                case "5+":
                case "+5":
                    this.AddGrade(140);
                    break;
                case "5":
                    this.AddGrade(130);
                    break;
                case "5-":
                case "-5":
                    this.AddGrade(120);
                    break;
                case "4+":
                case "+4":
                    this.AddGrade(110);
                    break;
                case "4":
                    this.AddGrade(100);
                    break;
                case "4-":
                case "-4":
                    this.AddGrade(90);
                    break;
                case "3+":
                case "+3":
                    this.AddGrade(80);
                    break;
                case "3":
                    this.AddGrade(70);
                    break;
                case "3-":
                case "-3":
                    this.AddGrade(60);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(50);
                    break;
                case "2":
                    this.AddGrade(40);
                    break;
                case "2-":
                case "-2":
                    this.AddGrade(30);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong grade:");

            }
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
