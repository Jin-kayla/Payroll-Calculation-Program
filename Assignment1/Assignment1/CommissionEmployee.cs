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
    internal class CommissionEmployee : Employee
    {

        private double _grossSales;

        public double GrossSales
        {
            get { return _grossSales; }
            set
            {
                if (value < 0)
                    throw new Exception("Gross sales must be greater than 0.");

                _grossSales = value; 
            }
        }

        private double _commissionRate;

        public double CommissionRate
        {
            get { return _commissionRate; }
            set
            {
                if (value < 0.0 || value > 1.0)
                    throw new Exception("Commission rate must be greater than 0 or less than 1.");

                _commissionRate = value; 
            }
        }

        //Derived Class - CommissionEmployee Constructor
        public CommissionEmployee(int ssn, string firstName, string lastName, DateTime birthday, double grossSales, double commissionRate) : base (ssn, firstName, lastName, birthday)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public override double Earnings()
        {
             return _grossSales * _commissionRate;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nGross Sales: $ {GrossSales}" + $"\nCommission Rate: {CommissionRate}";
        }

    }
}
