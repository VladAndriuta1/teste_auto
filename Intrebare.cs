 using System.Collections.Generic;
namespace teste_auto
{

    public class Intrebare
    {
        public int Id { get; set; }
        public string TextIntrebare { get; set; }
        public string Categorie { get; set; }
        public List<Raspuns> Variante { get; set; } = new List<Raspuns>();
    }
}