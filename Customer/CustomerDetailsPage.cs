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
        Console.WriteLine($"LastPurchase:  {_customer.LastPurchase}");
        Console.WriteLine($"Address: {_customer.Address}");

        // Fjernet Country og Currency, hvis ikke i Customer
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key)
        {
            case ConsoleKey.F2:
            case ConsoleKey.F1:
                Display(new CustomerEditPage(_customer));
                break;
            default:
                break;
        }
        //Console.ReadKey(true);
    }
}
