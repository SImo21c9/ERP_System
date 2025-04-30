using TECHCOOL.UI;
namespace ERP_System;

public class TodoListScreen : Screen
{
    public override string Title { get; set; } = "List of tasks to do";

    protected override void Draw()
    {
        Clear(); // Rydder skærmen

        ListPage<Todo> listPage = new ListPage<Todo>();

        // Tilføjer eksempler på TODO-opgaver
        listPage.Add(new Todo("Buy milk"));
        listPage.Add(new Todo("Walk the dog", 2));
        listPage.Add(new Todo("Clean toilet"));

        // Vis kolonne med titel
        listPage.AddColumn("Todo", "Title");

        listPage.Select(); // Vis listen og lad brugeren vælge
    }
}
