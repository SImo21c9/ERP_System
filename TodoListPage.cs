namespace ERP_System;
using TECHCOOL.UI;
 

public class TodoListScreen : Screen
{
    public override string Title { get; set; } = "List of tasks to do"; 
    protected override void Draw()
    {
        
        Clear(); //Clean the screen
        //Gonna draw a list page here
        ListPage<Todo> listPage = new ListPage<Todo>();
        listPage.Add(new Todo("Buy milk"));
        listPage.Add(new Todo("Walk the dog", 2));
        listPage.Add(new Todo("Clean toilet"));
        //...
        listPage.AddColumn("Todo", "Title");

        listPage.Draw();
    }
}