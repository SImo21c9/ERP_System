using TECHCOOL.UI;

namespace ERP_System;

public class CompanyListPage : Screen
{
    public override string Title {get; set;} = "Company";
 
    protected override void Draw()
    {
        ListPage<Company> lp = new();
        lp.AddColumn("Currency", nameof(Company.Currency));
        lp.AddColumn("Country", nameof(Company.Country));
        lp.AddColumn("CompanyName", nameof(Company.CompanyName));
 
        lp.Add(Database.Instance.GetCompanies());
 
        lp.Select();
    }
}