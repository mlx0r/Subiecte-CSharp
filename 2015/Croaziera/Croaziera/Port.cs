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
}
