namespace ERP_System;
using TECHCOOL.UI;

// Singleton-del af Database-klassen, sikrer én global instans
public partial class Database
{
    public static Database Instance { get; } = new Database();

    private Database()
    {
    }
}
