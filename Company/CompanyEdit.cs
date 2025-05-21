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
        editForm.SelectBox("Currency", "Currency");
        editForm.AddOption("Currency", "Dansk kroner", Currency.DKK);
        editForm.AddOption("Currency", "Svenske kroner", Currency.SEK);
        editForm.AddOption("Currency", "Euro", Currency.EUR);
        editForm.SelectBox("Country", "Country");
        Country[] topGdpCountries = new[]
        {
            Country.UnitedStates,
            Country.Denmark,
            Country.China,
            Country.Germany,
            Country.Sweden
        };
        foreach (var country in topGdpCountries)
        {
            editForm.AddOption("Country", country.ToString(), country);
        }

        if (editForm.Edit(_company))
        {
            Database.Instance.UpdateCompany(_company);
        }
        Display(new CompanyInfo(_company));
    }
}
