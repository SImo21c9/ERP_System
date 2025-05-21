using TECHCOOL.UI;
namespace ERP_System;

public class CustomerEditPage : Screen
{
    public override string Title { get; set; } = "Customer";
    private Customer _customer;
    public CustomerEditPage(Customer customer)
    {
        _customer = customer;
    }
    protected override void Draw()
    {
        Form<Customer> editForm = new();
        editForm.TextBox("Virksomhed", nameof(Customer.CompanyName));
        editForm.SelectBox("Currency", nameof(Customer.Currency));
        editForm.AddOption(nameof(Customer.Currency), "Dansk kroner", Currency.DKK);
        editForm.AddOption(nameof(Customer.Currency), "Svenske kroner", Currency.SEK);
        editForm.AddOption(nameof(Customer.Currency), "Euro", Currency.EUR);
        editForm.SelectBox("Country", nameof(Customer.Country));

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
            editForm.AddOption(nameof(Customer.Country), country.ToString(), country);
        }

        if (editForm.Edit(_customer))
        {
            Database.Instance.UpdateCustomer(_customer);
        }
        Display(new CustomerDetailsPage(_customer));
    }
}
