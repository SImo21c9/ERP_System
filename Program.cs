using TECHCOOL.UI;
namespace ERP_System;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialiser singleton-databasen
        /*new Database();

        // Tilføj testvirksomhed
        Database.Instance.AddCompany(new()
        {
            CompanyName = "LNE Security A/S",
            Country = Country.Denmark,
            Currency = Currency.DKK,
            Street = "Skibbyggerivej",
            StreetNumber = "5",
            City = "Aalborg",
            Address = "9000"
        }); */

        // Vis skærmen med virksomhedsliste
        //Screen.Display(new CompanyListPage());
        
        //for now this doesn't do anything because for some reason CompanyListPage doesn't return any values
        //But this is the way to go (at least we think)  
        CompanyListPage companyListPage = new CompanyListPage();
        Menu menu = new Menu();
        menu.Add(companyListPage);
        menu.Add(companyListPage);
        
        
        Screen.Display(menu);
        //menu.Add(new CompanyListPage());
        
        //Screen.Display(new MyMenuScreen());
        // Alternativt: vis andre screen
        //Screen.Display(new MyFirstScreen());
        //Screen.Display(new TodoListScreen());
    }
}
