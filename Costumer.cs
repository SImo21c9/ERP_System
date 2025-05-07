using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;

namespace ERP_System;

public class Costumer : Person
{
    private static HashSet<string> existingCostumers = new HashSet<string>();
    private string costumerId;
    public string Last_Purchase { get; set; } = DateTime.Now.ToString();

    public string CostumerId
    {
        get
        {
            return costumerId;
        }
        set
        {
            if (existingCostumers.Contains(value))
            {
                throw new ArgumentException("The Costumer Id already exists");
            }

            costumerId = value;
            existingCostumers.Add(value);
        }
    }
}