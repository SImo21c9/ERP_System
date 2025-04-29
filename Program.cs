using ERP_System;
using TECHCOOL.UI;
public class Program 
{
	public static void Main(string[] args)
	{
		
	    new Database();
		Database.Instance.AddCompany( new()
		{
			CompanyName = "LNE Security A/S", 
			Country = "Denmark",
			Currency = Currency.DKK, 
			Street = "Skibbyggerivej",
			StreetNumber = "5",
			City = "Aalborg",
			Address = "9000"
			
		});
		CompanyListPage companyListPage = new CompanyListPage();
		Screen.Display(companyListPage); 
		
		
		
		//MyFirstScreen firstScreen = new MyFirstScreen();
		//Screen.Display(firstScreen);
		//TodoListScreen todolistscreen = new TodoListScreen();
		//Screen.Display(todolistscreen);

		
	}
}

 
