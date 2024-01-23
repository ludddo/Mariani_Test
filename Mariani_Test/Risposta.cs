using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Test
{
    internal class Risposta
    {
        private string _testo;
        private int _punti;

        public string Testo
        {
            get { return _testo; }
            set { _testo = value; }
        }

        public int Punti
        {
            get { return _punti; }
            set { _punti = value; }
        }

        public Risposta()
        {
            Testo = "";
            Punti = 0;
        }

        public Risposta(string testo, int punti)
        {
            Testo = testo;
            Punti = punti;
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
            return $"{Testo};{Punti}";
        }

        public double Punteggio()
        {
            return Punti;
        }
    }
}
