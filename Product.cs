namespace ERP_System;

public enum Enhed
{
    Amount,
    Timer,
    Meter
}

public class Product
{
    public string ItemID { get; set; } = "";         // Unikt ID
    public string Name { get; set; } = "";               // Navn på produktet
    public string Description { get; set; } = "";        // Kort beskrivelse
    public decimal SalesPrice { get; set; }               // Pris kunden betaler
    public decimal BoughtPrice { get; set; }             // Pris du har givet
    public string Location { get; set; } = "";           // F.eks. "A12B"
    public decimal NumberInStorage { get; set; }            // Lagerantal i decimal
    public Enhed Enhed { get; set; }                     // F.eks. styk, meter

    // Beregn fortjeneste (salgspris - indkøbspris)
    public decimal Fortjeneste()
    {
        return SalesPrice - BoughtPrice;
    }

    // Beregn avance i procent
    public decimal AvanceProcent()
    {
        if (BoughtPrice == 0) return 0; // Undgå division med 0
        return (Fortjeneste() / BoughtPrice) * 100;
    }
}
