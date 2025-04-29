namespace ERP_System;

// Håndterer lagring og adgang til virksomhedsdata
public partial class Database
{
    private List<Company> companies = new(); // Intern liste over virksomheder

    // Finder og returnerer en virksomhed baseret på dens ID, eller null hvis den ikke findes
    public Company? GetCompanyById(int id)
    {
        foreach (var company in companies)
        {
            if (company.CompanyId == id)
            {
                return company; // Fundet – returnér virksomheden
            }
        }
        return null; // Ikke fundet – returnér null
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
            companies.Add(company);
        }
    }

    // Opdaterer en eksisterende virksomhed, hvis ID findes
    public void UpdateCompany(Company company)
    {
        if (company.CompanyId == 0)
        {
            return; // ID ikke angivet – kan ikke opdatere
        }

        Company? oldCompany = GetCompanyById(company.CompanyId);
        if (oldCompany == null)
        {
            return; // Virksomheden findes ikke
        }

        oldCompany.CompanyName = company.Name; // Opdater navnet
    }

    // Sletter en virksomhed baseret på ID
    public void DeleteCompany(int id)
    {
        Company? found = GetCompanyById(id);
        if (found != null)
        {
            companies.Remove(found);
        }
    }
}
