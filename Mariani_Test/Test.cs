using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Test
{
    internal class Test : IComponent
    {
        private List<IComponent> _lista;

        List<IComponent> Lista { get; set; }
        
        public Test() 
        {
            Lista = new List<IComponent>();
        }

        public Test(List<IComponent> lista)
        {
            Lista = new List<IComponent>();
        }

        public void Aggiunta(IComponent component)
        {
            Lista.Add(component);
        }

        public void Rimuovi(int index)
        {
            Lista.RemoveAt(index);
        }

        public IComponent GetChild(int index)
        {
            return Lista[index];
        }

        public override string ToString()
        {
            return ";";
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public int Punteggio(IComponent component)
        {
            return 0;
        }
    }
}
