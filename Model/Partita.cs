using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory.Model
{
    public class Partita
    {
        GestoreMatrice gestoreMatrice;
        Giocatore giocatore;

        public Partita()
        {
            giocatore = new Giocatore();
            gestoreMatrice = new GestoreMatrice(4, 4);
        }

        public bool ControllaCoppia(int riga, int colonna, int riga2, int colonna2)
        {
            Carta carta = giocatore.ScegliCarta(riga, colonna);
            Carta carta2 = giocatore.ScegliCarta(riga2, colonna2);
            bool giusto = false;
            if (carta == carta2)
            {
                giocatore.GestoreMatrice.MatriceCarte[riga, colonna] = null;
                giocatore.GestoreMatrice.MatriceCarte[riga2, colonna2] = null;
                giusto = true;
            }
            return giusto;
        }
    }
}