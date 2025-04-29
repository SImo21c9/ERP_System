namespace ERP_System;

public class Company
{
    public int ComapnyId { get; set; }
    public string Name { get; set; } = "";
    public string Street { get; set; } = "";
    public string StreetNumber { get; set; } = "";
    public string City { get; set; } = "";
    public string Country { get; set; } = "";
    public Currency Currency { get; set; }
    public string CampanyName { get; set; }

}
