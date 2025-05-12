using TECHCOOL.UI;
namespace ERP_System;

public class CustomerEdit : Screen
{
    public override string Title { get; set; } = "Customer";
    private Customer _customer;

    public CustomerEdit(Customer customer)
    {
        _customer = customer;
    }

    protected override void Draw()
    {
        Form<Customer> editForm = new();
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
        //HELLO DELETE ME PLEASE
        if (editForm.Edit(_customer))
        {
            Database.Instance.UpdateCompany(_customer);
        }

        Display(new CompanyInfo(_customer));

    }
}