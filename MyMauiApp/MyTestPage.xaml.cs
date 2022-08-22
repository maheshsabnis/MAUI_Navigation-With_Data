namespace MyMauiApp;
using MyMauiApp.Models;
using System.Text.Json;
public partial class MyTestPage : ContentPage
{
    
    public EmployeeList employees { get; set; }
	public MyTestPage()
	{
		InitializeComponent();
        employees = new EmployeeList();
	}

    async void btnClick_Clicked(System.Object sender, System.EventArgs e)
    {

        await DisplayAlert("Alert", "You have been alerted", "OK");
        for (int i = 0; i < employees.Count; i++)
        {
            employees[i] = ProcessTax.CalculateTax(employees[i]);
        }
        lstEmpData.ItemsSource = employees;

    }

    async void lstEmpData_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        var json = JsonSerializer.Serialize(lstEmpData.SelectedItem);
        var emp = (Employee)lstEmpData.SelectedItem;
       await DisplayAlert("Alert", json, "OK");
        // await Shell.Current.GoToAsync("./MainPage");
        // App.Current.MainPage = new NavigationPage(new MainPage());


        var navigationParameter = new Dictionary<string, object>
    {
        { "Employee",  emp}
    };


        await Shell.Current.GoToAsync($"Page1", navigationParameter);
    }
}
