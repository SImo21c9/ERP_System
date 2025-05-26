using TECHCOOL.UI;

namespace ERP_System;

public class SalesOrderList : Screen
{
    public override string Title { get; set; } = "Salgsordreliste";

    protected override void Draw()
    {
        ListPage<SalesOrder> lp = new();

        lp.AddColumn("Ordrenr", "OrderNumber");
        lp.AddColumn("Dato", "OrderDate");
        lp.AddColumn("Kundenr", "CustomerId");
        lp.AddColumn("Kundenavn", "CustomerFullName");
        lp.AddColumn("Beløb", "TotalAmount");

        lp.Run(Database.Instance.GetSalesOrders());
    }
}
