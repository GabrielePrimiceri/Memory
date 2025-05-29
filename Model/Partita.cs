using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory.Model
{
    public class Partita
    {
        
        Giocatore giocatore;

        public Partita(List <Carta> listaCarte)
        {
            giocatore = new Giocatore();
            for (int i = 0; i<listaCarte.Count; i++)
            {
                giocatore.GestoreMatrice.InserisciCarte(listaCarte[i]);
            }
        }

        public bool ControllaCoppia(int riga, int colonna, int riga2, int colonna2)
        {
            Carta carta = giocatore.ScegliCarta(riga, colonna);
            Carta carta2 = giocatore.ScegliCarta(riga2, colonna2);
            bool giusto = false;
            if (carta.Equals(carta2))
            {

                giusto = true;
                giocatore.GestoreMatrice.MatriceCarte[riga, colonna] = null;
                giocatore.GestoreMatrice.MatriceCarte[riga2, colonna2] = null;
            }
            return giusto;
        }

        public int RilevaValoreCarta(int riga, int colonna)
        {
            return giocatore.ScegliCarta(riga, colonna).Numero;
        }


    }
}