using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Test
{
    internal class Singola : Domanda
    {
        private string _testo;

        string Testo { get; set; }

        public Singola()
        {
            Testo = "";
        }

        public Singola(string testo)
        {
            Testo = testo;
        }


        public override bool Equals(object obj)
        {
            return false;
        }

        public void Aggiunta(IComponent comp)
        {

        }

        public void Rimuovi(int index)
        {

        }

        public IComponent GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return Testo;
        }

        public int Punteggio()
        {
            return 0;
        }
    }
}
