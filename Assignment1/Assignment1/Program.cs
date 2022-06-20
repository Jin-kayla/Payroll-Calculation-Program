/*
 * Assignment 1
 * PROG32356 
 * Name: Jinyoung Jeon
 * Student ID: 991622283
 */


using Assignment1;

//initilization
List<Employee> empList = new List<Employee>();

DateTime b1 = new DateTime(1990,05,17);
DateTime b2 = new DateTime(1980,06,17);
DateTime b3 = new DateTime(2000,01,17);
DateTime b4 = new DateTime(1972,02,17);

DateTime now = DateTime.Now;
//Console.WriteLine(now);
int month = now.Month;
//Console.WriteLine(month);

SalariedEmployee emp1 = new SalariedEmployee(100, "Peter", "Cider", b1, 1900);
empList.Add(emp1);

HourlyEmployee emp2 = new HourlyEmployee(101, "Tom", "Butter", b2, 21, 40);
empList.Add(emp2);

CommissionEmployee emp3 = new CommissionEmployee(102, "Rachel", "Milkshake", b3, 10000, 0.25);
empList.Add(emp3);

SalaryPlusCommissionEmployee emp4 = new SalaryPlusCommissionEmployee(104, "Luke", "Zero", b4, 10000, 0.10, 400);
empList.Add(emp4);


for (int i = 0; i < empList.Count; i++)
{
    Console.WriteLine("\nEmployee " + (i+1));
    Console.WriteLine(empList[i]);

    int bMonth = empList[i].Birthday.Month;

    //Console.WriteLine(bMonth);

    if (bMonth == month) {
        Console.WriteLine($"Earnings for each week: $ {empList[i].Earnings() + 100}");
        Console.WriteLine($"Payroll for this month: $ {4*(empList[i].Earnings() + 100)}\n");
        Console.WriteLine("---------------------------------------------------");
    } else {
        Console.WriteLine($"Earnings for each week: $ {empList[i].Earnings()}");
        Console.WriteLine($"Payroll for this month: $ {4*(empList[i].Earnings())}\n");
        Console.WriteLine("---------------------------------------------------");
    }
    
}

