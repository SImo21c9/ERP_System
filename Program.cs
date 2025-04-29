using ERP_System;
using TECHCOOL.UI;
public class Program 
{
	public static void Main(string[] args)
	{
		new Database();
		Database.Instance.AddCompany( new()
		{
			CompanyName = "Hans"

		});
		
		//MyFirstScreen firstScreen = new MyFirstScreen();
		//Screen.Display(firstScreen);
		//TodoListScreen todolistscreen = new TodoListScreen();
		//Screen.Display(todolistscreen);

		CompanyListPage companyListPage = new CompanyListPage();
		Screen.Display(companyListPage);
		//List<Company> companies = new List<Company> { new Company { Name = "Virksomhed 1" }, new Company { Name = "Virksomhed 2" } };
		//Screen.Display(companies);
	}
}

 
