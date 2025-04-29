using TECHCOOL.UI;

namespace ERP_System;

public class CompanyListPage : Screen
{
    public override string Title {get; set;} = "Company";
 
    protected override void Draw()
    {
        ListPage<Company> lp = new();
        lp.AddColumn("Name", nameof(Company.Name));
        lp.AddColumn("Street", nameof(Company.Street));
 
        lp.Add(Database.Instance.GetCompanies());
 
        lp.Select();
    }
}