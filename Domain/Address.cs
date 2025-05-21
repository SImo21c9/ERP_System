namespace ERP_System;
using TECHCOOL.UI;

public class Address
{
    public string Street { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string HouseNumber { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string StreetNumber { get; set; } = "";
    public string Country { get; set; } = "";

    public string GetAddress()
    {
        return $"{HouseNumber},{Street}, {StreetNumber}, {City}, {State}, {PostalCode}, {Country}";
    }
}
