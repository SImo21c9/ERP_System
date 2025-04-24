using TECHCOOL.UI;
namespace ERP_System;

public abstract class ColorScreen : Screen
{
    public ColorScreen() : base()
    {
        DefaultForeground = ConsoleColor.Yellow;
        DefaultBackground = ConsoleColor.Blue;
        FocusForeground = ConsoleColor.Green;
        FocusBackground = ConsoleColor.Cyan;
        FieldForeground = ConsoleColor.White;
        FieldBackground = ConsoleColor.DarkGray;
    }
}