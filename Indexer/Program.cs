// See https://aka.ms/new-console-template for more information

using Indexer;
using System.Xml.Serialization;

var emps = new Employee[]
{
    new Employee {Id=1, Name="Issam A", Gender="M", TotalSales=65000m},
    new Employee {Id=2, Name="Reem S", Gender="F", TotalSales=50000m},
    new Employee {Id=3, Name="Suzan B", Gender="F", TotalSales=65000m},
    new Employee {Id=4, Name="Sara A", Gender="F", TotalSales=40000m},
    new Employee {Id=5, Name="Salah C", Gender="M", TotalSales=42000m},
    new Employee {Id=6, Name="Rateb A", Gender="M", TotalSales=30000m},
    new Employee {Id=7, Name="Abeer C", Gender="F", TotalSales=16000m},
    new Employee {Id=8, Name="Marwan M", Gender="M", TotalSales=15000m} ,
};

Report report = new Report();

//----------------------------(1)-----------------
//report.ProcessEmployeeWithSalesPlus60000(emps);
//report.ProcessEmployeeWithSalesBetween30000And59999(emps);
//report.ProcessEmployeeWithSalesLessThan30000(emps);

//----------------------------(2)-----------------
//report.ProcessEmployee(emps, " Sales >=60 000", IsGreaterThan60k);
//report.ProcessEmployee(emps, " Sales between 30k and 59999", IsBetween30kAnd59999);
//report.ProcessEmployee(emps, " Sales less than 30k", IsLessThan30k);

//----------------------------(3)-----------------
//report.ProcessEmployee(emps, " Sales >=60 000", delegate (Employee e) { return e.TotalSales >= 60000; });
//report.ProcessEmployee(emps, " Sales between 30k and 59999", delegate (Employee e) { return e.TotalSales >= 30000 && e.TotalSales <= 59999; });
//report.ProcessEmployee(emps, " Sales less than 30k", delegate (Employee e) { return e.TotalSales < 30000; });

//----------------------------(4)-----------------
//report.ProcessEmployee(emps, " Sales >=60 000",  (Employee e) => e.TotalSales >= 60000);
//report.ProcessEmployee(emps, " Sales between 30k and 59999",  (Employee e) => e.TotalSales >= 30000 && e.TotalSales <= 59999);
//report.ProcessEmployee(emps, " Sales less than 30k", (Employee e) => e.TotalSales < 30000);

//----------------------------(5)-----------------
report.ProcessEmployee(emps, " Sales >=60 000",  e => e.TotalSales >= 60000);
report.ProcessEmployee(emps, " Sales between 30k and 59999",  e => e.TotalSales >= 30000 && e.TotalSales <= 59999);
report.ProcessEmployee(emps, " Sales less than 30k",  e => e.TotalSales < 30000);
Console.ReadKey();

//----------------------------(2)-----------------
//static bool IsGreaterThan60k(Employee e) => e.TotalSales >= 60000;
//static bool IsBetween30kAnd59999(Employee e) => e.TotalSales >= 30000 && e.TotalSales <=59999;
//static bool IsLessThan30k(Employee e) => e.TotalSales < 30000;