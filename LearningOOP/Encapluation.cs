using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    internal class Person
    {
        // private key word denotes only member of same class can access it;
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _address;

        public Person() { }
        public Person(int id, string firstName, string lastName, string email, string phone, string address)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phone = phone;
            _address = address;
        }
        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { this._firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { this._lastName = value; }
        }
        public String Email
        {
            get { return _email; }
            set { this._email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { this._phone = value; }
        }
        public string Address
        {
            get { return _address; }
            set { this._address = value; }
        }
    }
}
