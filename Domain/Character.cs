using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Character
    {
        public Character(int mut, int klugheit, int intuition, int charisma, int fingerfertigkeit, int gewandtheit, int konstitution, int körperkraft)
        {
            Mut = mut;
            Klugheit = klugheit;
            Intuition = intuition;
            Charisma = charisma;
            Fingerfertigkeit = fingerfertigkeit;
            Gewandtheit = gewandtheit;
            Konstitution = konstitution;
            Körperkraft = körperkraft;
        }

        public int Mut { get; set; }
        public int Klugheit { get; set; }
        public int Intuition { get; set; }
        public int Charisma { get; set; }
        public int Fingerfertigkeit { get; set; }
        public int Gewandtheit { get; set; }
        public int Konstitution { get; set; }
        public int Körperkraft { get; set; }
    }
}
