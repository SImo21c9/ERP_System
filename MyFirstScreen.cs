using TECHCOOL.UI;
namespace ERP_System;

public class MyFirstScreen : Screen
{
    public override string Title { get; set; } = "My first screen";

    protected override void Draw()
    {
        Clear(); // Rydder sk�rmen
        Console.WriteLine("My first screen!"); // Simpel demo
    }
}
