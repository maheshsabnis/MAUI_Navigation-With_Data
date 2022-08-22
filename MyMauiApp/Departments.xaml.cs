namespace MyMauiApp;
using MyMauiApp.Models;
 

public partial class Departments : ContentPage
{
    public DepartmentList DepartmentsList { get; set; }
    public Departments()
    {

        InitializeComponent();
        DepartmentsList = new DepartmentList();
        this.BindingContext = this;
    }
    /// <summary>
    /// The Selected Item Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    async void lstDepartments_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        // Get the selected Department from the ListItem
        var dept = (Department)lstDepartments.SelectedItem;
        // Create a Navigation Parameter using the Dictionary
        var navigationParameter = new Dictionary<string, object>
    {
        { "SelectedDepartment",  dept}
    };

        // Navigate to the Employees Route with the Navigation Parameter
        await Shell.Current.GoToAsync($"Employees", navigationParameter);
    }
}
