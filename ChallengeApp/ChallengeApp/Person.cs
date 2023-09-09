
namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
         
        }
        public string Name { get; private set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            
        }
        public string Surname { get; private set; }

        public Person(string gender, string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Name = gender;
        }
        public string Gender { get; private set; }
    }
}
