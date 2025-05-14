using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory.Model
{
    public class Giocatore
    {
        public GestoreMatrice GestoreMatrice { get; set; }
        public Carta ScegliCarta(int riga, int colonna)
        {
            if (riga < 0 || colonna < 0 || riga > GestoreMatrice.MatriceCarte.GetLength(0) || colonna > GestoreMatrice.MatriceCarte.GetLength(1) || GestoreMatrice.MatriceCarte[riga, colonna] == null) throw new ArgumentOutOfRangeException("");
            return GestoreMatrice.MatriceCarte[riga, colonna];
        }
    }
}