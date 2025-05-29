using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory.Model
{
    public class GestoreMatrice
    {
       
        private Carta[,]? _matriceCarte;

        public Carta[,]? MatriceCarte
        {
            get { return _matriceCarte; }
            set { _matriceCarte = value; }
        }

        public GestoreMatrice(int righe, int colonne)
        {
            MatriceCarte = new Carta[righe, colonne];
            
        }

        public void InserisciCarte(Carta carta)
        {
            Random _random = new Random();
            foreach(Carta i in _matriceCarte)
            {
                if (i == null)
                {
                    break;
                }
            }
            int randomRighe = _random.Next(0, MatriceCarte.GetLength(0) );
            int randomColonne = _random.Next(0, MatriceCarte.GetLength(1) );
            do
            {
                randomRighe = _random.Next(0, MatriceCarte.GetLength(0) );
                randomColonne = _random.Next(0, MatriceCarte.GetLength(1) );

                if (MatriceCarte[randomRighe, randomColonne] == null)
                {
                    MatriceCarte[randomRighe, randomColonne] = carta;
                    break;
                }
            } while (MatriceCarte[randomRighe, randomColonne] != null);
        }
    }
}