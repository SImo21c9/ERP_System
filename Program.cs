using ERP_System;
using TECHCOOL.UI;
public class Program 
{
	public static void Main(string[] args)
	{
		//MyFirstScreen firstScreen = new MyFirstScreen();
		//Screen.Display(firstScreen);
		TodoListScreen todolistscreen = new TodoListScreen();
		Screen.Display(todolistscreen);
	}
}