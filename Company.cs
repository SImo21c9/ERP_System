using ERP_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Company 
{
    public int CompanyId { get; set; }              // ID (bruges til søgning/opdatering)
    public string CompanyName { get; set; } = "";   // Visningsnavn (bruges i UI)
    public string Name { get; set; } = "";
    public Address Address { get; set; } = new Address();
    public string Street => Address.Street;        // Vejnavn
    public string Company_StreetNumber
    {
        get => Address.; // Husnummer
 
    }

    public string City { get; set; } = "";          // By
    public string PostCode { get; set; } = "";      // Postnummer
    public Country Country { get; set; }             // Land
    public Currency Currency { get; set; }           // Valuta

    // Dynamisk beregnet adresse
    public string Company_Address
    {
        get => $"{Street} {StreetNumber}, {PostCode} {City}";
    }

}
