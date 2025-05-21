namespace ERP_System;
using TECHCOOL.UI;

// H�ndterer lagring og adgang til virksomhedsdata
public partial class Database
{
    private List<Company> companies = new(); // Intern liste over virksomheder
    private int nextCompanyId = 1;

    // Finder og returnerer en virksomhed baseret p� dens ID, eller null hvis den ikke findes
    public Company? GetCompanyById(int id)
    {
        foreach (var company in companies)
        {
            if (company.CompanyId == id)
            {
                return company; // Fundet � return�r virksomheden
            }
        }
        return null; // Ikke fundet � return�r null
    }

    // Returnerer alle virksomheder i en array
    public Company[] GetCompanies()
    {
        return companies.ToArray(); // Konverterer listen til et array
    }

    // Tilføjer en virksomhed hvis den endnu ikke har et ID
    public void AddCompany(Company company)
    {
        if (company.CompanyId == 0)
        {
            company.CompanyId = nextCompanyId++;
            company.Name = company.CompanyName; // Sørg for at Name også er sat
            companies.Add(company);
        }
    }

    // Opdaterer en eksisterende virksomhed, hvis ID findes
    public void UpdateCompany(Company company)
    {
        if (company.CompanyId == 0)
        {
            AddCompany(company);
            return; // ID ikke angivet � kan ikke opdatere
        }

        Company? oldCompany = GetCompanyById(company.CompanyId);
        if (oldCompany == null)
        {
            return; // Virksomheden findes ikke
        }

        oldCompany.CompanyName = company.CompanyName;
        oldCompany.Name = company.CompanyName; 
        oldCompany.Street = company.Street;
        oldCompany.StreetNumber = company.StreetNumber;
        oldCompany.City = company.City;
        oldCompany.Address = company.Address;
        oldCompany.Country = company.Country;
        oldCompany.Currency = company.Currency;
    }

    // Sletter en virksomhed baseret p� ID
    public void DeleteCompany(int id)
    {
        Company? found = GetCompanyById(id);
        if (found != null)
        {
            companies.Remove(found);
        }
    }
}