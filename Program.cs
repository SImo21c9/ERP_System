using TECHCOOL.UI;
namespace ERP_System;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialiser singleton-databasen
        new Database();

        // Tilføj testvirksomhed
        Database.Instance.AddCompany(new()
        {
            CompanyName = "LNE Security A/S",
            Country = "Denmark",
            Currency = Currency.DKK,
            Street = "Skibbyggerivej",
            StreetNumber = "5",
            City = "Aalborg",
            Address = "9000"
        });

        // Vis skærmen med virksomhedsliste
        Screen.Display(new CompanyListPage());

        // Alternativt: vis andre screen
        //Screen.Display(new MyFirstScreen());
        //Screen.Display(new TodoListScreen());
    }
}
