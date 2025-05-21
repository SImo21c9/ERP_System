namespace ERP_System;
using System.Collections.Generic;

public class SalesOrder
{
    public string OrderNumber { get; set; }
    public string CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    // Tilføj evt. flere felter som OrderLines, Status osv.
}