
using TECHCOOL.UI;
public class MyFirstScreen : Screen
{
    public override string Title { get; set; } = "My first screen"; 
    protected override void Draw()
    {
        //...
        Clear();
        Console.WriteLine("My first screen!");
    }
}