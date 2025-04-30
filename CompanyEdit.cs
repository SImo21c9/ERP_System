using TECHCOOL.UI;

namespace ERP_System;

public class CompanyEdit : Screen
{
    public override string Title { get; set; } = "Company";
    private Company _company;
    
    public CompanyEdit(Company company)
    {
        _company = company;
    }


    protected override void Draw()
    {
        Form<Company> editForm = new();
        editForm.TextBox("Virksomhed", nameof(Company.CompanyName));
        editForm.AddOption("Currency", "Dansk kroner", Currency.DKK);
        editForm.AddOption("Currency", "Svenske kroner", Currency.SEK);
        editForm.AddOption("Currency", "Euro", Currency.EUR);
        editForm.TextBox("Land", nameof(Company.Country));

        if (editForm.Edit(_company))
        {
            Database.Instance.UpdateCompany(_company);
        }

        Display(new CompanyInfo(_company));
    }
}