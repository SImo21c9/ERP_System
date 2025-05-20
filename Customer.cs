using System;
using System.Collections.Generic;

namespace ERP_System;

public class Customer : Person
{
    /// <summary>
    /// Here we made a Hashset which is a type of collections that stores specific data (need to double-check i might have forgotten what it actually does since it's been a while since i wrote it)
    /// We are storing customerid that cannot be repeated and as you can below that there is an exception that makes sre that a customer id is not repeated 
    /// </summary>
    private static HashSet<string> existingCostumers = new HashSet<string>();
    private string costumerId;
    public string LastPurchase { get; set; } = DateTime.Now.ToString();

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
    
    

    // Dynamisk beregnet adresse
    public string Customer_Address
    {
        get => $"{Street} {StreetNumber}, {PostCode} {City}";
        
    }

    public string FullName => FirstName + " " + LastName;
   
}