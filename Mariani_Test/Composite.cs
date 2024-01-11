using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Test
{
    public abstract class Component
    {
        public abstract void Aggiunta(Component componente);

        public abstract void Rimuovi(int index);

        public new abstract bool Equals(object obj);

        public new abstract string ToString();
    }
}
