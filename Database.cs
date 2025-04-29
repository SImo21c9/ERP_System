namespace ERP_System;

public partial class Database
{
    public static Database Instance { get; set; }

    public Database()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}