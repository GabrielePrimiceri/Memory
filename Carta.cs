using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWork_Memory
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
    }
}