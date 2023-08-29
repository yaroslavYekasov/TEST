using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Student
    {
        public string Name { get; }
        public int age;
        private readonly string _city;
        public string status;
        public int DateNow;

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }

        public int Age
        {
            get { return age; } 
            set 
            { 
                age = value;
                if (age < 18) status = "alaealine";
                else status = "täisksvanud";
            }
        }

        public string Status
        { get { return status; } }


        public string GetCity()
        {
            return _city;
        }

        public int BirthDate()
        {
            
            int d = DateTime.Now.Year;
            int realAge = d - DateTime.Now.Month;
            return realAge;


        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
            Console.WriteLine(BirthDate());
        }
    }
}
