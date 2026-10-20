namespace Croaziera;

public class Port
{
    public Port(int id, string nume, Point pozitie)
    {
        Id = id;
        Nume = nume;
        Pozitie = pozitie;
    }

    public int Id { get; }
    public string Nume { get; }

    public Point Pozitie { get; }

    public static Dictionary<int, string> NumberToName = new()
    {
        [1] = "Constanta",
        [2] = "Varna",
        [3] = "Burgas",
        [4] = "Istambul",
        [5] = "Kozlu",
        [6] = "Samsun",
        [7] = "Batumi",
        [8] = "Sokhumi",
        [9] = "Soci",
        [10] = "Anapa",
        [11] = "Yalta",
        [12] = "Sevastopol",
        [13] = "Odessa",
    };

}
