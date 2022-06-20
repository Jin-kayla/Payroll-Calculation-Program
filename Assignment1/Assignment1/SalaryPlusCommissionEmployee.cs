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
    internal class SalaryPlusCommissionEmployee : CommissionEmployee
    {

        private double _baseSalary;

        public double BaseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }

        //Derived Class - SalaryPlusCommissionEmployee Constructor
        public SalaryPlusCommissionEmployee(int ssn, string firstName, string lastName, DateTime birthday, double grossSales, double commissionRate, double baseSalary) : base(ssn, firstName, lastName, birthday, grossSales, commissionRate)
        {
            _baseSalary = baseSalary;
        }

        public override double Earnings()
        {
            return _baseSalary + base.Earnings();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nBase Salary: $ {BaseSalary}";
        }

    }
}
