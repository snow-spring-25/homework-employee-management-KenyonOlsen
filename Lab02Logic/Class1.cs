using System.ComponentModel;
using System.Dynamic;
using System.Reflection;
using Microsoft.VisualBasic;

namespace Lab02Logic;

public class Employee
{
    public Employee()
    {

    }
    public Employee(string firstName, string lastName, decimal hourlyPay,decimal hoursWorked)
    {
        FirstName=firstName;
        LastName=lastName;
        HourlyPay=hourlyPay;
        HoursWorked=hoursWorked;
        TotalPay=HoursWorked*HourlyPay;
    }
    

    public string? FirstName{get; set;}
    public string? LastName{get; set;}
    public decimal HourlyPay{get; set;}
    public decimal HoursWorked{get; set;}
    public decimal TotalPay{get;}




}

public class EmployeeManager
{
    public EmployeeManager()
    {

    }
    public EmployeeManager(string firstName, string lastName)
    {

    }
    public static decimal CombinedPay=0;
    public List<Employee> EmployeeList = [];
    public void AddEmployee(string firstName,string lastName, decimal hourlyPay, decimal hoursWorked)
    {
        Employee newEmployee = new Employee(firstName,lastName, hourlyPay, hoursWorked);
        EmployeeList.Add(newEmployee);
        CombinedPay+=newEmployee.TotalPay;
    }
}
