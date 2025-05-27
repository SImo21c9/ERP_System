using TECHCOOL.UI;

namespace ERP_System;

public class SalesOrderList : Screen
{
    public override string Title { get; set; } = "SalesOrderDetail";

    protected override void Draw()
    {
        ListPage<SalesOrder> lp = new();
        lp.AddKey(ConsoleKey.F1, CreateOrder);
        lp.AddColumn("OrderNumber",  nameof(SalesOrder.OrderNumber));
        lp.AddColumn("OrderDate", nameof(SalesOrder.OrderDate));
        lp.AddColumn("CustomerNumber", nameof(SalesOrder.CustomerId));
        lp.AddColumn("Full name", nameof(Customer.FullName));

        foreach (SalesOrder salesorder in Database.Instance.GetSalesOrders())
        {
            lp.Add(salesorder);
        }

        SalesOrder? selected = lp.Select();
        
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.F1: // Opret
                SalesOrder newSalesOrder = new();
                Display(new SalesOrderEdit(newSalesOrder));
                break;
            case ConsoleKey.F2: // Rediger
                if (selected != null)
                    Display(new SalesOrderEdit(selected));
                break;
            default:
                if (selected != null)
                    Display(new SalesOrderEdit(selected));
                break;
        }
    }
    void CreateOrder(SalesOrder _)
    {
        SalesOrder salesOrder = new();
        Display(new SalesOrderEdit(new SalesOrder()));
    }
        
}