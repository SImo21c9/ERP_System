using ERP_System;
using System;
using TECHCOOL.UI;

public class Company 
{
    public int CompanyId { get; set; }              // ID (bruges til søgning/opdatering)
    public string CompanyName { get; set; } = "";   // Visningsnavn (bruges i UI)
    public string Name { get; set; } = "";
    public string HouseNumber { get; set; } ="";
    public Address Address { get; set; } = new Address();
    public string Street
    {
        get => Address.Street; // Vejnavn

        set => Address.Street = value;
    }

    public string City { get; set; } = "";          // By

    public string Company_StreetNumber;
    public string StreetNumber
    {
        get => Address.HouseNumber;// Husnummer
        set
        {
            Address.HouseNumber = value;
        }
    }

    public string PostCode { get; set; } = "";      // Postnummer
    public Country Country { get; set; }             // Land
    public Currency Currency { get; set; }           // Valuta

    // Dynamisk beregnet adresse
    public string Company_Address
    {
        get => $"{Street} {StreetNumber}, {PostCode} {City}";
    }
}
