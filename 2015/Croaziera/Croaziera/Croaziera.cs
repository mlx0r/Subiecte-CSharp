namespace Croaziera;


public class Croaziera
{
    public int Id { get; set; }
    public int Tip { get; set; }
    public required List<int> ListaPorturi { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? Final { get; set; }
    public int Pret { get; set; }
    public int NrPasageri { get; set; }

    public List<string> ListaPorturiCuNumePorturi()
    {
        List<string> numePorturi = [];
        foreach (var numarPort in ListaPorturi)
        {
            var numePort = Port.NumberToName[numarPort];
            numePorturi.Add(numePort);
        }

        return numePorturi;
    }
}


