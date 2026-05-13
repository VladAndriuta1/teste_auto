using System.Collections.Generic;

namespace teste_auto
{
    public class Intrebare
    {
        public int Id { get; set; }
        public string TextIntrebare { get; set; }
        public string Categorie { get; set; }
        public string ImagineUrl { get; set; }
        public List<Raspuns> Variante { get; set; } = new List<Raspuns>();

        // Starea întrebării în test
        public bool? RaspunsCorect { get; set; } = null; // null=neatins, true=corect, false=greșit
        public bool Amanata { get; set; } = false;
        public int IndexRaspunsSelectat { get; set; } = -1;
    }
}