/*
namespace TECHCOOL.UI;

public class ListPage<T>
{
    private List<T> items = new();
    private List<(string Header, string PropertyName)> columns = new();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Add(IEnumerable<T> itemsToAdd)
    {
        items.AddRange(itemsToAdd);
    }

    public void AddColumn(string header, string propertyName)
    {
        columns.Add((header, propertyName));
    }

    public void Select()
    {
        foreach (var item in items)
        {
            foreach (var column in columns)
            {
                var prop = typeof(T).GetProperty(column.PropertyName);
                var value = prop?.GetValue(item);
                Console.Write($"{column.Header}: {value}    ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n[Enter] to continue...");
        Console.ReadLine();
    }
}
*/