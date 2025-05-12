using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;

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