namespace ERP_System;
using TECHCOOL.UI;

public  class CompanyInfo : Screen
{
    public override string Title { get; set; } = "Company";
    private Company _company;

    public CompanyInfo(Company company)
    {
        _company = company;
        
    }

    protected override void Draw()
    {
        Console.WriteLine("Try");
        
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key, key)
        {
            case ConsoleKey.F2:
                Display((new CompanyEdit(_company)));
                break;
        }
    }
}