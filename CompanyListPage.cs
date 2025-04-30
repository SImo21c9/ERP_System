namespace ERP_System;
using TECHCOOL.UI;


// Skærmbillede der viser listen over virksomheder
public class CompanyListPage : Screen
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

        lp.Select(); // Start interaktiv visning
    }
}
