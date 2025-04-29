namespace ERP_System;

// Singleton-del af Database-klassen, sikrer �n global instans
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
