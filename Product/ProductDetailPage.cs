using TECHCOOL.UI;

namespace ERP_System;

public class ProductDetailPage : Screen
{
    public override string Title { get; set; } = "Product";

    protected override void Draw()
    {
        ListPage<Product> lp = new();
        lp.AddColumn("ProductNumber", nameof(Product.ItemID));
        lp.AddColumn("Name", nameof(Product.Name));
        lp.AddColumn("Description", nameof(Product.Description));
        lp.AddColumn("SalesPrice", nameof(Product.SalesPrice));
        lp.AddColumn("BoughtPrice", nameof(Product.BoughtPrice));
        lp.AddColumn("Location", nameof(Product.Location));
        lp.AddColumn("QuantityInStock", nameof(Product.QuantityInStock));
        lp.AddColumn("Unit ", nameof(Product.Unit));
        lp.AddColumn("AvanceProcent", nameof(Product.AvanceProcent));
        lp.AddColumn("Profit", nameof(Product.Profit));

        foreach (Product product in Database.Instance.GetProducts())
        {
            lp.Add(product);
        }

        Product? selected = lp.Select();

        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.F1: // Opret
                Product newProduct = new();
                Display(new ProductEdit(newProduct));
                break;
            case ConsoleKey.F2: // Rediger
                if (selected != null)
                    Display(new ProductEdit(selected));
                break;
            default:
                if (selected != null)
                    Display(new ProductEdit(selected));
                break;
        }
    }
}