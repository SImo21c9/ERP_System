using ERP_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

public class CustomerDetailsPage : Screen
{
    public override string Title { get; set; } = "Customer Details";
    private Customer _customer;

    public CustomerDetailsPage(Customer customer)
    {
        _customer = customer;
    }

    protected override void Draw()
    {
        Clear();
        Console.WriteLine($"Name: {_customer.FullName}");
        Console.WriteLine($"Phone: {_customer.PhoneNumber}");
        Console.WriteLine($"Email: {_customer.Email}");
        // Fjernet Country og Currency, hvis ikke i Customer

        Console.ReadKey(true);
    }
}
