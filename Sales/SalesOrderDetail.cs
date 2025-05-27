using TECHCOOL.UI;

namespace ERP_System;

public class SalesOrderDetail : Screen
{
    public override string Title { get; set; } = "Salgsordreliste";
    private SalesOrder _salesorder;

    public SalesOrderDetail(SalesOrder salesorder)
    {
        _salesorder = salesorder;
    }
    protected override void Draw()
    {
        ListPage<SalesOrder> lp = new();
        lp.AddColumn("Ordrenr", "OrderNumber");
        lp.AddColumn("Dato", "OrderDate");
        lp.AddColumn("Kundenr", "CustomerId");
        lp.AddColumn("Kundenavn", "CustomerFullName");
        lp.AddColumn("Bel�b", "TotalAmount");

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch  (keyInfo.Key)
        {
            case ConsoleKey.F2:
            case ConsoleKey.F1:
                Display(new SalesOrderEdit(_salesorder));
                break;
            default:
                break;
        }
    }

   
}