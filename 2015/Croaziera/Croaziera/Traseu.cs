namespace Croaziera;

public class Traseu
{
    private const int NumarTotalPorturi = 13;

    public List<int> GenerareTraseu(int portStart, int nrZile)
    {
        bool esteValidNrZile = nrZile == 3 || nrZile == 5 || nrZile == 8;

        if (!esteValidNrZile)
        {
            throw new Exception($"Nr zile invalid! {nrZile}");
        }
        List<int> listaPorturi = [];
        listaPorturi.Add(portStart);

        for (int i = 1; i < nrZile; i++)
        {
            listaPorturi.Add(Next(portStart, i));
        }
        listaPorturi.Add(portStart);
        return listaPorturi;
    }

    private int Next(int start, int decalaj)
    {
        if (start + decalaj == NumarTotalPorturi)
        {
            return NumarTotalPorturi;
        }
        return (start + decalaj) % NumarTotalPorturi;
    }
}