namespace ERP_System;
using TECHCOOL.UI;
using System.Linq;

public partial class CompanyListPage : Screen
{
    public override string Title { get; set; } = "Company";

    protected override void Draw()
    {
        ListPage<Company> lp = new(); // Opret listevisning for virksomheder
        // Tilføj kolonner til visning
        lp.AddColumn("Currency", nameof(Company .Currency));
        lp.AddColumn("Country", nameof(Company.Country));
        lp.AddColumn("Company Name", nameof(Company.CompanyName));
        lp.AddColumn("City", nameof(Company.City));
        lp.AddColumn("Street", nameof(Company.Street));
        lp.AddColumn("Street Number", nameof(Company.StreetNumber));
        lp.AddColumn("Address", nameof(Company.Address));

        // Tilføj data fra databasen
        foreach (var company in Database.Instance.GetCompanies())
        {
            lp.Add(company);
        }

        Company? selected = lp.Select(); // Start interaktiv visning

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key)
        {
            case ConsoleKey.F1: // Opret ny virksomhed
                Company newCompany = new();
                Display(new CompanyEdit(newCompany));
                break;

            case ConsoleKey.F2: // Rediger valgte virksomhed
                if (selected != null)
                {
                    Display(new CompanyEdit(selected));
                }
                break;

            case ConsoleKey.F5: // Slet valgte virksomhed
                if (selected != null)
                {
                    Database.Instance.DeleteCompany(selected.CompanyId);
                    Display(new CompanyListPage()); // Opdater visningen
                }
                break;

            default:
                if (selected != null)
                {
                    Display(new CompanyInfo(selected));
                }
                break;
        }
    }
}
