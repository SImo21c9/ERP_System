namespace ERP_System;
using TECHCOOL.UI;

public class CompanyInfo : Screen
{
    public override string Title { get; set; } = "Company";
    private Company _company;

    public CompanyInfo(Company company)    
    {
        _company = company;
    }

    protected override void Draw()
    {
        Clear();
        Console.WriteLine("Try F2 for editing");
        Console.WriteLine("");
        Console.WriteLine("Virksomhed: " + _company.CompanyName);
        Console.WriteLine("Currency: " + _company.Currency);

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key)
        {
            case ConsoleKey.F2:
            case ConsoleKey.F1:
                Display(new CompanyEdit(_company));
                break;
            default:
                break;
        }
    }
}
