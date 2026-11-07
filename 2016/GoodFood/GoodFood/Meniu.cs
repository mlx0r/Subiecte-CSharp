namespace GoodFood;

public partial class FormOptiuni
{
    public class Meniu
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public int Pret { get; set; }
        public int Kcal { get; set; }
        public int Felul { get; set; }
    };
}
