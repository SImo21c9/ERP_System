using TECHCOOL.UI;
public class MyFirstScreen : Screen
{
    public override string Title { get; set; } = "My first screen";

    protected override void Draw()
    {
        Clear(); // Rydder skærmen
        Console.WriteLine("My first screen!"); // Simpel demo
    }
}
