namespace Croaziera;

public class Utils
{
    public static string GetBasePath()
    {
        var currDir = Directory.GetCurrentDirectory();
        var basePath = Directory.GetParent(currDir).Parent.Parent.FullName;
        return basePath;
    }

    public static string GetConnectionString()
    {
        return $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetBasePath()}\\CroazieraDB.mdf;Integrated Security=True";
    }
}
