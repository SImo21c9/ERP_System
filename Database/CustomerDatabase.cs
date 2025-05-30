﻿namespace ERP_System;

using Microsoft.Data.SqlClient;
using TECHCOOL.UI;

// Håndterer lagring og adgang til kundedata
public partial class Database
{
    private List<Customer> customers = new(); // Intern liste over kunder
    private int nextCustomerId = 1;

    // Finder og returnerer en kunde baseret på dens ID, eller null hvis den ikke findes
    public Customer? GetCustomerById(int id)
    {
        foreach (var customer in customers)
        {
            if (customer.CustomerId == id)
            {
                return customer; // Fundet – returnér kunden
            }
        }
        return null; // Ikke fundet – returnér null
    }

    // Returnerer alle kunder i en array
    public List<Customer> GetCustomers()
    {
        // Konverterer listen til et array
        List<Customer> list = new List<Customer>();

        SqlConnection conn = GetConnection();

        SqlCommand cmd = conn.CreateCommand();

        cmd.CommandText = "SELECT list FROM GetCustomers;";
        

        return list;
    }


    // Tilføjer en kunde hvis den endnu ikke har et ID
    public void AddCustomer(Customer customer)
    {
        if (customer.CustomerId == 0)
        {
            customer.CustomerId = nextCustomerId++;
            customers.Add(customer);
        }
    }

    // Opdaterer en eksisterende kunde, hvis ID findes
    public void UpdateCustomer(Customer customer)
    {
        if (customer.CustomerId == 0)
        {
            AddCustomer(customer);
            return; // ID ikke angivet – kan ikke opdatere
        }

        Customer? oldCustomer = GetCustomerById(customer.CustomerId);
        if (oldCustomer == null)
        {
            return; // Kunden findes ikke
        }

        oldCustomer.CompanyName = customer.CompanyName;
        oldCustomer.Street = customer.Street;
        oldCustomer.StreetNumber = customer.StreetNumber;
        oldCustomer.City = customer.City;
        oldCustomer.Address = customer.Address;
        oldCustomer.Country = customer.Country;
    }

    // Sletter en kunde baseret på ID
    public void DeleteCustomer(int id)
    {
        Customer? found = GetCustomerById(id);
        if (found != null)
        {
            customers.Remove(found);
        }
    }
}
