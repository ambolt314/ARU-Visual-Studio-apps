using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PDFGeneratorComparison
{
    public class Person
    {
        public string foreName;
        public string surname;
        public DateTime dateOfBirth;
        
        public Person(string foreName, string surname, DateTime dateOfBirth) {
            this.foreName = foreName;
            this.surname = surname; 
            this.dateOfBirth = dateOfBirth;
        }


        public int getAge() { return DateTime.Now.Year - dateOfBirth.Year; }
        public string getName() { return $"{foreName} {surname}"; }
    }

    internal class Adult : Person
    {
        Adult spouse;

        public Adult(string foreName, string surname, DateTime dateOfBirth) : base(foreName, surname, dateOfBirth)
        {
            this.foreName = foreName;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
        }

        public void Work(string job, string company)
        {
            Console.WriteLine($"{getName()} is working as a {job} at {company}");
        }

        public void Marry(Adult partner)
        {
            partner.spouse = this;
            this.spouse = partner;

            Console.WriteLine($"{getName()} and {partner.getName()} have just married!");
        }

        bool IsMarried()
        {
            return spouse != null;
        }
    }

    internal class Child : Person
    {
        public List<Child> friends;

        public Child(string foreName, string surname, DateTime dateOfBirth) : base(foreName, surname, dateOfBirth)
        {
            friends = new List<Child>();
            this.foreName = foreName;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
        }

        public void Play() { Console.WriteLine($"{this.getName()} is playing with their friends"); }

        public void MakeFriend(Child newFriend)
        {
            if (newFriend.getAge() > (getAge()/2)+7) {
                friends.Add(newFriend);
                newFriend.friends.Add(this);
            }
            else
            {
                Console.WriteLine($"You're too old to be my friend, {newFriend.getName()}!");
            }
            
        }

        public void SameBirthday(Child other)
        {
            if (dateOfBirth.Day == other.dateOfBirth.Day && dateOfBirth.Month == other.dateOfBirth.Month)
            {
                MakeFriend(other);
            }
        }
    }
}
