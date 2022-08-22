using System.Collections.ObjectModel;
using MyMauiApp.Models;

namespace MyMauiApp.Views;

public partial class Employees : ContentPage,IQueryAttributable
{
    public ObservableCollection<Employee> EmployeesList { get; set; }
    public string DeptName { get; set; }
    public Employees()
	{
		InitializeComponent();
		EmployeesList = new EmployeeList();
        this.BindingContext = this;
        OnPropertyChanged();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var dept = query["SelectedDepartment"] as Department;
       
        DeptName = dept.DeptName;

        var Emps = new EmployeeList();

        for (int i = 0; i < Emps.Count; i++)
        {
            Emps[i] = ProcessTax.CalculateTax(EmployeesList[i]);
        }
        var filteredData = Emps.Where(e => e.DeptNo == dept.DeptNo);
        EmployeesList.Clear();
        
        foreach (var emp in filteredData)
        {

            EmployeesList.Add(emp);
            
        }
        OnPropertyChanged();

    }
}
