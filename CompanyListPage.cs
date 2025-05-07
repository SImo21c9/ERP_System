using TECHCOOL.UI;
namespace ERP_System;
using TECHCOOL.UI;
public partial class CompanyListPage : Screen
{
    public override string Title { get; set; } = "Company";

    protected override void Draw()
    {

        ListPage<Company> lp = new(); // Opret listevisning for virksomheder
        // Tilføj kolonner til visning
        lp.AddColumn("Currency", nameof(Company.Currency));
        lp.AddColumn("Country", nameof(Company.Country));
        lp.AddColumn("Company Name", nameof(Company.CompanyName));
        lp.AddColumn("City", nameof(Company.City));
        lp.AddColumn("Street", nameof(Company.Street));
        lp.AddColumn("Street Number", nameof(Company.StreetNumber));
        lp.AddColumn("Address", nameof(Company.Address));
        

        // Tilføj data fra databasen
        lp.Add(Database.Instance.GetCompanies());

        Company selected = lp.Select(); // Start interaktiv visning

        if (selected != null)
        {
            
            Display(new CompanyInfo(selected));
        }

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        
        if (keyInfo.Key == ConsoleKey.F1)
        {
            Company newCompany = new();
            Database.Instance.AddCompany(newCompany);
            Display(new CompanyEdit(newCompany));
        }
    }
}
