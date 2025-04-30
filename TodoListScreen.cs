using TECHCOOL.UI;
public class TodoListScreen : Screen
{
    public override string Title { get; set; } = "List of tasks to do";

    protected override void Draw()
    {
        Clear(); // Rydder sk�rmen

        ListPage<Todo> listPage = new ListPage<Todo>();

        // Tilf�jer eksempler p� TODO-opgaver
        listPage.Add(new Todo("Buy milk"));
        listPage.Add(new Todo("Walk the dog", 2));
        listPage.Add(new Todo("Clean toilet"));

        // Vis kolonne med titel
        listPage.AddColumn("Todo", "Title");

        listPage.Select(); // Vis listen og lad brugeren v�lge
    }
}
