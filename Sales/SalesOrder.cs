namespace ERP_System;
using System.Collections.Generic;

public class SalesOrder
{
    public int SalesOrderId { get; set; }           // Intern ID
    public string OrderNumber { get; set; } = "";   // Ekstern ID
    public string Customer { get; set; } = "";      // Kundens navn eller ID
    public string CustomerId { get; set; } = "";      // Kundens navn eller ID
    public DateTime OrderDate { get; set; }              // Dato for ordren
    public DateTime Date { get; set; }              // Dato for ordren
    public string Status { get; set; } = "";        // Fx "Afsluttet", "Åben", "Annulleret"
    public List<Product> Products { get; set; } = new(); // Liste over produkter
    public string Name { get; set; } = "";          // Bruges til visning i UI
    public decimal TotalAmount { get; set; }        // Totalbeløb
    

}