using System;
using System.Collections.ObjectModel;

namespace MyMauiApp.Models
{
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }

    public class DepartmentList : ObservableCollection<Department>
    {
        public DepartmentList()
        {
            Add(new Department() { DeptNo = 10, DeptName = "Information Technology"});
            Add(new Department() { DeptNo = 20, DeptName = "Human Resource" });
            Add(new Department() { DeptNo = 30, DeptName = "Administration" });
            Add(new Department() { DeptNo = 40, DeptName = "Maintenence" });
            Add(new Department() { DeptNo = 50, DeptName = "Transport" });
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public decimal Tax { get; set; }
        public int DeptNo { get; set; }
    }
    public static class ProcessTax
    {
        public static Employee CalculateTax(Employee emp)
        {
            System.Threading.Thread.Sleep(100);
            emp.Tax = emp.Salary * Convert.ToDecimal(0.4);
            return emp;
        }
    }
    public class EmployeeList : ObservableCollection<Employee>
    {
        public EmployeeList()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "Mahesh", Salary = 21000,DeptNo=10 });
            Add(new Employee() { EmpNo = 2, EmpName = "Tejas", Salary = 22000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 3, EmpName = "Ramesh", Salary = 23000, DeptNo = 30 });
            Add(new Employee() { EmpNo = 4, EmpName = "Ram", Salary = 24000, DeptNo = 40 });
            Add(new Employee() { EmpNo = 5, EmpName = "Shankar", Salary = 25000, DeptNo = 50 });
            Add(new Employee() { EmpNo = 6, EmpName = "Vivek", Salary = 26000, DeptNo = 10 });
            Add(new Employee() { EmpNo = 7, EmpName = "Satish", Salary = 27000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 8, EmpName = "Mukesh", Salary = 28000, DeptNo = 30 });
            Add(new Employee() { EmpNo = 9, EmpName = "Sandeep", Salary = 29000, DeptNo = 40 });
            Add(new Employee() { EmpNo = 10, EmpName = "Vinay", Salary = 30000, DeptNo = 50 });
            Add(new Employee() { EmpNo = 11, EmpName = "Sharad", Salary = 31000, DeptNo = 10 });
            Add(new Employee() { EmpNo = 12, EmpName = "Sanjay", Salary = 32000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 13, EmpName = "Vijay", Salary = 33000, DeptNo = 30 });
            Add(new Employee() { EmpNo = 14, EmpName = "Vilas", Salary = 34000, DeptNo = 40 });
            Add(new Employee() { EmpNo = 15, EmpName = "Abhay", Salary = 35000, DeptNo = 50 });
            Add(new Employee() { EmpNo = 16, EmpName = "Nandu", Salary = 36000, DeptNo = 10 });
            Add(new Employee() { EmpNo = 17, EmpName = "Anil", Salary = 37000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 18, EmpName = "Jaywant", Salary = 38000, DeptNo = 30 });
            Add(new Employee() { EmpNo = 19, EmpName = "Abhay", Salary = 39000, DeptNo = 40 });
            Add(new Employee() { EmpNo = 20, EmpName = "Shyam", Salary = 40000, DeptNo = 50 });
            Add(new Employee() { EmpNo = 21, EmpName = "Anil", Salary = 41000, DeptNo = 10 });
            Add(new Employee() { EmpNo = 22, EmpName = "Vasant", Salary = 42000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 23, EmpName = "Sameer", Salary = 43000, DeptNo = 30 });
            Add(new Employee() { EmpNo = 24, EmpName = "Rahul", Salary = 44000, DeptNo = 40 });
            Add(new Employee() { EmpNo = 25, EmpName = "Abhishek", Salary = 45000, DeptNo = 50 });
            Add(new Employee() { EmpNo = 26, EmpName = "Kaushubh", Salary = 46000, DeptNo = 10 });

        }
    }


}

