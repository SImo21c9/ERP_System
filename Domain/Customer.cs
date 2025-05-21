using System;
using System.Collections.Generic;

namespace ERP_System;

public class Customer : Person
{
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
    public string Name { get; set; } = "";


    public string CostumerId { get; set; } = "";
    
    public string LastPurchase { get; set; } = DateTime.Now.ToString();
    // Dynamisk beregnet adresse
    public string Customer_Address
    {
        get => $"{Street} {StreetNumber}, {PostCode} {City}";
        
    }
    // customer full name 
    public string FullName => FirstName + " " + LastName;
   
}