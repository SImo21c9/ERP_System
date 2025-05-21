namespace ERP_System;
using TECHCOOL.UI;

// H�ndterer lagring og adgang til virksomhedsdata
public partial class Database
{
    private List<Product> products = new(); // Intern liste over virksomheder
    private int nextProductId = 1;

    // Finder og returnerer en virksomhed baseret p� dens ID, eller null hvis den ikke findes
    public Product? GetProductById(int id)
    {
        foreach (var product in products)
        {
            if (product.ProductId == id)
            {
                return product; // Fundet � return�r virksomheden
            }
        }
        return null; // Ikke fundet � return�r null
    }

    // Returnerer alle virksomheder i en array
    public Product[] GetProducts()
    {
        return products.ToArray(); // Konverterer listen til et array
    }

    // Tilføjer en virksomhed hvis den endnu ikke har et ID
    public void AddProduct(Product product)
    {
        if (product.ProductId == 0)
        {
            product.ProductId = nextProductId++;
            product.Name = product.ItemID; // Sørg for at Name også er sat
            products.Add(product);
        }
    }

    // Opdaterer en eksisterende virksomhed, hvis ID findes
    public void UpdateProduct(Product product)
    {
        if (product.ProductId == 0)
        {
            AddProduct(product);
            return; // ID ikke angivet � kan ikke opdatere
        }

        Product? oldProduct = GetProductById(product.ProductId);
        if (oldProduct == null)
        {
            return;
        }
        oldProduct.Name = product.Name;
        oldProduct.Description = product.Description;
        oldProduct.BoughtPrice = product.BoughtPrice;
        oldProduct.SalesPrice = product.SalesPrice;
        oldProduct.QuantityInStock = product.QuantityInStock;
        oldProduct.Location = product.Location;
        oldProduct.Unit = product.Unit;

       
    }

    // Sletter en virksomhed baseret p� ID
    public void DeleteProduct(int id)
    {
        Product? found = GetProductById(id);
        if (found != null)
        {
            products.Remove(found);
        }
    }
}