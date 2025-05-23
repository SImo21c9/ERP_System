using TECHCOOL.UI;

namespace ERP_System;

public class SalesOrderDetail : Screen
{
    public override string Title { get; set; } = "SalesOrderDetail";

    protected override void Draw()
    {
        ListPage<SalesOrder> lp = new();
        lp.AddColumn("OrderNumber",  nameof(SalesOrder.OrderNumber));
        lp.AddColumn("OrderDate", nameof(SalesOrder.OrderDate));
        lp.AddColumn("CustomerNumber", nameof(SalesOrder.CustomerId));
        lp.AddColumn("Full name", nameof(Customer.FullName));
    }

   
}