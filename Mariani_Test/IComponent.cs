using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Test
{
    public interface IComponent
    {
        void Aggiunta(IComponent component);

        void Rimuovi(int index);

        IComponent GetChild(int index);

        bool Equals(object obj);

        string ToString();

        int Punteggio(IComponent component);
    }
}