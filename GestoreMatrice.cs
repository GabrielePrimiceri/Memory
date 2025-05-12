using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory
{
    public class GestoreMatrice
    {
        Random _random;
        private Carta[,]? _matriceCarte;

        public Carta[,]? MatriceCarte
        {
            get { return _matriceCarte; }
            set { _matriceCarte = value; }
        }

        public GestoreMatrice(int righe, int colonne)
        {
            MatriceCarte=new Carta[righe,colonne];
            _random = new Random();
        }

        public void InserisciCarte(Carta carta)
        {
            int randomRighe = _random.Next(0, MatriceCarte.GetLength(0) + 1); ;
            int randomColonne = _random.Next(0, MatriceCarte.GetLength(1) + 1);
            if (MatriceCarte[randomRighe, randomColonne] == null)
            {
                MatriceCarte[randomRighe, randomColonne] = carta;
            }
            else throw new Exception("Errore, la carta non può essere inserita");
        }
    }
}