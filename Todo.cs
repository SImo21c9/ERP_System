public class Todo
{
    // Enum til at markere opgavens status
    public enum TodoState { Todo, Started, Done }

    public string Title { get; set; } = "";    // Titel/beskrivelse af opgaven
    public int Priority { get; set; }          // Prioritet (lav = vigtigst)
    public TodoState State { get; set; }       // Status

    public Todo(string title, int priority = 1)
    {
        Title = title;
        Priority = priority;
    }

    public Todo() { } // Tom constructor til evt. UI eller deserialisering
}
