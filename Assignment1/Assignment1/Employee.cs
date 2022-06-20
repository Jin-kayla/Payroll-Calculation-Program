using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Assignment 1
 * PROG32356 
 * Name: Jinyoung Jeon
 * Student ID: 991622283
 */

namespace Assignment1
{
    public abstract class Employee
    {

        private int _SSN;
        public int SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }


        //Constructor
        public Employee(int ssn, string firstName, string lastName, DateTime birthday)
        {
            SSN = ssn;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        //method - Earnings() 
        public abstract double Earnings();       

        public override string ToString()
        {
            return $"Social Security Number: {SSN}" +
                $"\nFirst Name: {FirstName}" +
                $"\nLast Name: {LastName}";
        }


    }
}
