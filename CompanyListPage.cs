using TECHCOOL.UI;

namespace ERP_System;

public class CompanyListPage : Screen
{
    public override string Title { get; set; } = "Virksomheder";

    protected override void Draw()
    {
        List<Company> companies = new List<Company>();
    }
}