﻿
namespace ChallengeApp
{
    public class Employee : Person
    {



        private List<float> grades = new List<float>();




        public Employee(string name)
            : this(name, "no surname")

        { 

        }
        public Employee(string name, string surname)
            : base(name, surname)

        {


        }
        public Employee(string name, string surname, string gender)
            : base(name, surname, gender)


        { 

        }



        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {


            if (grade >= 0 && grade <= 160)

            {

                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Value is out of range 0-160. ");

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
                throw new Exception("String if not float");

            }


        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);

        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(160);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(40);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(20);
                    break;
                case 'E':
                case 'q':
                    this.grades.Add(10);
                    break;
                default:
                    throw new Exception("Wrong Letter");



            }

        }



        public Statistics GetStatistics()
        {
            const int superValue = 5;
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            foreach (var grade in this.grades)



            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }

            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case float average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;

                case float average when average >= 40:
                    statistics.AverageLetter = 'B';
                    break;
                case float average when average >= 20:
                    statistics.AverageLetter = 'C';
                    break;
                case float average when average >= 10:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;


        }


    }
}
