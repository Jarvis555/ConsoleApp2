using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class User
    {
        private string fName;
        private string lName;
        private int age;
        private string email;

        public override string ToString()
        {
            return string.Format($"User: {fName} {lName} is {age} years old\nEmail: {email}");
        }

        public User(string fName, string lName, int age, string email)
        {
            this.FName = fName;
            this.LName = lName;
            this.Age = age;
            this.Email = email;
        }

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
    }
}
