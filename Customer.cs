using System;
using System.Collections.Generic;

namespace ERP_System;

public class Customer : Person
{
    private static HashSet<string> existingCustomers = new HashSet<string>();

    public int CustomerId { get; set; }
    public int CompanyId { get; set; }              // ID (bruges til søgning/opdatering)
    public string CompanyName { get; set; } = "";   // Visningsnavn (bruges i UI)
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Street { get; set; } = "";        // Vejnavn
    public string StreetNumber { get; set; } = "";  // Husnummer
    public string City { get; set; } = "";          // By
    public string PostCode { get; set; } = "";      // Postnummer
    public Country Country { get; set; }             // Land
    public Currency Currency { get; set; }           // Valuta

    // Dynamisk beregnet adresse
    public string Address => $"{Street} {StreetNumber}, {PostCode} {City}";
    public string FullName => FirstName + " " + LastName;

    public DateTime LastPurchase { get; set; } = DateTime.Now;

    // Her kan du tilføje yderligere properties/metoder relevant for Customer
}
