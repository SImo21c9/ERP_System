namespace ERP_System;

public enum Enhed
{
    Styk,
    Timer,
    Meter
}

public class Product
{
    public string Varenummer { get; set; } = "";         // Unikt ID
    public string Navn { get; set; } = "";               // Navn på produktet
    public string Beskrivelse { get; set; } = "";        // Kort beskrivelse
    public decimal Salgspris { get; set; }               // Pris kunden betaler
    public decimal Indkøbspris { get; set; }             // Pris du har givet
    public string Lokation { get; set; } = "";           // F.eks. "A12B"
    public decimal AntalPåLager { get; set; }            // Lagerantal i decimal
    public Enhed Enhed { get; set; }                     // F.eks. styk, meter

    // Beregn fortjeneste (salgspris - indkøbspris)
    public decimal Fortjeneste()
    {
        return Salgspris - Indkøbspris;
    }

    // Beregn avance i procent
    public decimal AvanceProcent()
    {
        if (Indkøbspris == 0) return 0; // Undgå division med 0
        return (Fortjeneste() / Indkøbspris) * 100;
    }
}
