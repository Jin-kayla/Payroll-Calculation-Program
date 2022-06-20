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
    internal class SalariedEmployee : Employee
    {
        private double _weeklySalary;

        public double WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //derived Class - Salaried Employee constructor
        public SalariedEmployee(int ssn, string firstName, string lastName, DateTime birthday, double weeklySalary) : base (ssn, firstName, lastName, birthday)
        {
            _weeklySalary = weeklySalary;
        }
     

        public override double Earnings()
        {
            return _weeklySalary;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nWeekly Salary: $ {WeeklySalary}";
        }
    }
}
