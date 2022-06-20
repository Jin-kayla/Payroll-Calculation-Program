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
    internal class HourlyEmployee : Employee
    {
        private int _hours;

        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        private double _wage;

        public double Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        //Derived Class - Hourly Employee Constructor
        public HourlyEmployee(int ssn, string firstName, string lastName, DateTime birthday, int hours, double wage) : base(ssn, firstName, lastName, birthday){
            _hours = hours;
            _wage = wage;      
        }

        public override double Earnings()
        {

            if (_hours <= 40)
            {
                return _wage* _hours;
                
            }
            else {
                return 40 * _wage + (_hours - 40) * _wage * 1.5;
                
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nWeekly Wage (calculated by hourly wage): $ {Earnings()}";
        }
    }
}
