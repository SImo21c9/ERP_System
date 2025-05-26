namespace ERP_System;
using TECHCOOL.UI;

public class SalesOrderEdit : Screen
{
    public override string Title { get; set; } = "SalesOrder Edit ";
    private SalesOrder _salesorder;

    public SalesOrderEdit(SalesOrder salesorder)
    {
        _salesorder = salesorder;
    }

    protected override void Draw()
    {
        Form<SalesOrder> editForm = new();
        editForm.TextBox("ProductNumber ", nameof(Product.ItemID));
        editForm.TextBox("Name ", nameof(Product.Name));
        editForm.TextBox("Description ", nameof(Product.Description));
        editForm.TextBox("SalesPrice", nameof(Product.SalesPrice));
        editForm.TextBox("BoughtPrce", nameof(Product.BoughtPrice));
        editForm.TextBox("Location", nameof(Product.Location));
        editForm.TextBox("Quantity", nameof(Product.QuantityInStock));
        editForm.TextBox("Unit", nameof(Product.Unit));
        editForm.TextBox("ProductId", nameof(Product.ProductId));

        if (editForm.Edit(_salesorder))
        {
            Database.Instance.UpdateSalesOrder(_salesorder);
        }
        Display(new SalesOrderList(_salesorder));
    }
}