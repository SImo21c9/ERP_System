using TECHCOOL.UI;
namespace ERP_System;

public class Program
{
    public static void Main(string[] args)
    {
        new Database();
        Database.Instance?.AddCompany(new() {Name = "Test", Street = "Teset", StreetNumber = "1", City = "Test", Country  = Country.China, Currency = Currency.DKK, PostCode = "1234"});
        Database.Instance?.AddCompany(new() {Name = "Test2", Street = "Teset2", StreetNumber = "2", City = "Test2", Country = Country.Denmark, Currency = Currency.EUR, PostCode = "1234"});
        
        CompanyListPage companylistpage = new();
        Menu mainMenu = new();
        mainMenu.Add(companylistpage); 
        Screen.Display(mainMenu);
        
         //a mistake on purpose 
    }
}
