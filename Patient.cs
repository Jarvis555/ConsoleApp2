using System;

namespace ConsoleApp2
{
    class Patient
    {
        private string name;
        private string address;
        private string city;
        private string state;
        private string phoneNum;
        private string zip;

        public override string ToString()
        {
            string str = String.Format("Name      : {0}\nAddress   : {1}\nCity/State: {2}, {3} {4}\nContact   : {5}",
                            Name, Address, City, State, Zip, PhoneNum);
            str = $"Name      : {Name}\nAddress   : {Address}\nCity/State: {City}, {State} {Zip}\nContact   : {PhoneNum}";
            return str;
        }

        public Patient(string name, string address, string city, string state, string zip, string phoneNum)
        {
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PhoneNum = phoneNum;
            this.Zip = zip;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string State { get => state; set => state = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Zip { get => zip; set => zip = value; }
        public string City { get => city; set => city = value; }
    }
}
