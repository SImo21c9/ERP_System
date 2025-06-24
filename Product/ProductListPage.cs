using TECHCOOL.UI;
namespace ERP_System;

public class ProductListPage : Screen
{
    public override string Title { get; set; } = "Product List";
    private Product _product;

    public ProductListPage(Product product)
    {
        _product = product;
    }

    protected override void Draw()
    {
        Clear();
        ListPage<Product> lp = new();
        lp.AddColumn("ProductId", nameof(Product.ItemID));
        lp.AddColumn("Name", nameof(Product.Name));
        lp.AddColumn("Stock", nameof(Product.QuantityInStock));
        lp.AddColumn("Bought Price", nameof(Product.BoughtPrice));
        lp.AddColumn("Sales Price", nameof(Product.SalesPrice));       
        lp.AddColumn("ProfitMargin", nameof(Product.Profit));
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key)
        {
            case ConsoleKey.F2:
            case ConsoleKey.F1:
                Display(new ProductEdit(_product));
                break;
            default:
                break;
        }
        
    }

}
