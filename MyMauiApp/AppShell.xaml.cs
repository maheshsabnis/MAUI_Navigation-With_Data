namespace MyMauiApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("Employees", typeof(MyMauiApp.Views.Employees));
        Routing.RegisterRoute("EmployeeDetials", typeof(MyMauiApp.Views.EmployeeDetails));
    }
}
