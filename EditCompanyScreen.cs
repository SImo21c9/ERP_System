using TECHCOOL.UI;

namespace ERP_System;

public class CompanyListPage : Screen
{
    public override string Title { get; set; } = "Company";

    protected override void Draw()
    {
        ListPage<Company> lp = new();
        lp.AddColumn("Currency", nameof(Company.Currency));
        lp.AddColumn("Country", nameof(Company.Country));
        lp.AddColumn("Company Name", nameof(Company.CompanyName));
        lp.AddColumn("City", nameof(Company.City));
        lp.AddColumn("Street", nameof(Company.Street));
        lp.AddColumn("Street Number", nameof(Company.StreetNumber));
        lp.AddColumn("Address", nameof(Company.Address));

        lp.Add(Database.Instance.GetCompanies());

        // LP kan enten vælge eller redigere
        Company selected = lp.Select();

        if (selected != null)
        {
            // Vis en ny redigeringsskærm direkte via .Edit()
            lp.Edit(selected);

            // Opdater objektet i databasen
            Database.Instance.UpdateCompany(selected);
        }
    }
}
