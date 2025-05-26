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
         editForm.TextBox("First Name ", nameof(Customer.FirstName));
         editForm.TextBox("Last Name", nameof(Customer.LastName));
         editForm.TextBox("Street ", nameof(Customer.Street));
         editForm.TextBox("House Number", nameof(Customer.HouseNumber));
         editForm.TextBox("PostCode", nameof(Customer.PostCode));
         editForm.TextBox("City", nameof(Customer.City));
         editForm.TextBox("Phone Number", nameof(Customer.PhoneNumber));
         editForm.TextBox("Email", nameof(Customer.Email));

        if (editForm.Edit(_salesorder))
        {
            Database.Instance.UpdateSalesOrder(_salesorder);
        }
        Display(new SalesOrderList());
    }
}