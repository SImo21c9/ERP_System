namespace ERP_System;

public partial class Database
{
    private List<Company> companies = new();

    public Company? GetCompanyById(int id)
    {
        foreach (var company in companies)
        {
            if (company.CompanyId == id)
            {
                return company;
            }

            return null;
        }

        return null;
    }


        Company[] GetCompanies()
        {
            Company[] list = new Company[companies.Count];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = companies[i];
            }

            return companies.ToArray();
        }

        public void AddCompany(Company company)
        {
            if (company.CompanyId == 0)
            {
                companies.Add(company);
            }
        }

        public void UpdateCompany(Company company)
        {
            if (company.CompanyId == 0)
            {
                return;
            }

            Company? oldCompany = GetCompanyById(company.CompanyId);
                if (oldCompany == null)
                {
                    return;
                }

                oldCompany.CompanyName = company.Name;
        }
        
        public void DeleteCompany(int id)
        {
            Company? found = GetCompanyById(id);
            if (found != null)
            {
                companies.Remove(found);
            }
        }
        
        
}