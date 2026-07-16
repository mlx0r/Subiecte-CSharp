
namespace Matrimoniale;

public class Persoana
{
    public Persoana(string nume, string prenume, string ocupatie, string sex, decimal varsta)
    {
        Nume = nume;
        Prenume = prenume;
        Ocupatie = ocupatie;
        Sex = sex;
        Varsta = varsta;
    }

    public string Nume { get; }
    public string Prenume { get; }
    public string Ocupatie { get; }
    public string Sex { get; }
    public decimal Varsta { get; }
}
