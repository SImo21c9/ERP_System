using TECHCOOL.UI;

namespace ERP_System;

public class ProductEdit : Screen
{
    public override string Title { get; set; } = "Product Edit ";
    private Product _product;

    public ProductEdit(Product product)
    {
        _product = product;
    }

    protected override void Draw()
    {
        Form<Product> editForm = new();
        editForm.TextBox("ProductNumber ", nameof(Product.ItemID));
        editForm.TextBox("Name ", nameof(Product.Name));
        editForm.TextBox("Description ", nameof(Product.Description));
        editForm.TextBox("SalesPrice", nameof(Product.SalesPrice));
        editForm.TextBox("BoughtPrce", nameof(Product.BoughtPrice));
        editForm.TextBox("Location", nameof(Product.Location));
        editForm.TextBox("Quantity", nameof(Product.QuantityInStock));
        editForm.TextBox("Unit", nameof(Product.Unit));
        editForm.TextBox("ProductId", nameof(Product.ProductId));

        if (editForm.Edit(_product))
        {
            Database.Instance.UpdateProduct(_product);
        }
        Display(new ProductListPage(_product));
    }
}