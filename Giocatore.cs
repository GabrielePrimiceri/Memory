using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory
{
    public class Giocatore
    {
        private GestoreMatrice _gestoreMatrice;
        public Giocatore()
        {

        }
        public Carta ScegliCarta(int riga, int colonna)
        {
            if(riga<0||colonna<0||riga>_gestoreMatrice.MatriceCarte.GetLength(0)||colonna > _gestoreMatrice.MatriceCarte.GetLength(1) || _gestoreMatrice.MatriceCarte[riga,colonna]==null) throw new ArgumentOutOfRangeException("");
            return _gestoreMatrice.MatriceCarte[riga, colonna];
        }
    }
}