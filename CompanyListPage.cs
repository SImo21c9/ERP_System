using TECHCOOL.UI;

namespace ERP_System;

public class CompanyListPage : Screen
{
    public override string Title {get; set;} = "Company";
 
    protected override void Draw()
    {
        ListPage<Company> lp = new();
        lp.AddColumn("Name", nameof(Company.Name));
 
        lp.Add(Database.Instance.GetCompanyById());
 
        lp.Select();
    }
}