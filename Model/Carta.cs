using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory.Model
{
    public class Carta
    {
        private int _numero;
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Errore");
                _numero = value;
            }
        }
        public Carta(int numero)
        {
            Numero = numero;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Carta) return false;
            Carta carta = obj as Carta;
            if (carta.Numero == Numero) return true;
            else return false;
        }
    }
}