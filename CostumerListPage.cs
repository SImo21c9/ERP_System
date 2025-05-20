namespace ERP_System;
using TECHCOOL.UI;
using System.Linq;

public class CustomerListPage : Screen
{
    public override string Title { get; set; } = "Customer List";

    protected override void Draw()
    {
        ListPage<Customer> lp = new();
        lp.AddColumn("Customer ID", nameof(Customer.CustomerId));
        lp.AddColumn("Name", nameof(Customer.FullName));
        lp.AddColumn("Phone", nameof(Customer.PhoneNumber));
        lp.AddColumn("Email", nameof(Customer.Email));

        foreach (Customer customer in Database.Instance.GetCustomers())
        {
            lp.Add(customer);
        }
        Customer? selected = lp.Select();

        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.F1: // Opret
                Customer newCustomer = new();
                Display(new CustomerEditPage(newCustomer));
                break;
            case ConsoleKey.F2: // Rediger
                if (selected != null)
                    Display(new CustomerEditPage(selected));
                break;
            default:
                if (selected != null)
                    Display(new CustomerDetailsPage(selected));
                break;
        }
    }
}
