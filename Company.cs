namespace ERP_System;
using TECHCOOL.UI;


// Repr�senterer en virksomhed med adresse og information
public class Company
{
    public int CompanyId { get; set; }              // ID (bruges til s�gning/opdatering)
    public string Name { get; set; } = "";          // Internt navn (bruges fx i Update)
    public string Street { get; set; } = "";        // Vejnavn
    public string StreetNumber { get; set; } = "";  // Husnummer
    public string City { get; set; } = "";          // By
    public string Address { get; set; } = "";       // Postnummer eller samlet adresse
    public string Country { get; set; } = "";       // Land
    public Currency Currency { get; set; }          // Valuta
    public string CompanyName { get; set; }         // Visningsnavn (bruges i UI)
}
