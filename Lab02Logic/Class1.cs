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
    public Employee(string firstName, string lastName)
    {
        FirstName=firstName;
        LastName=lastName;
    }

    string? FirstName{get; set;}
    string? LastName{get; set;}
    decimal HourlyPay{get; set;}
    decimal HoursWorked{get; set;}
    decimal TotalPay{get;}




}
