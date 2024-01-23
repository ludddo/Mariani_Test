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

        public void Add(IComponent component)
        {
            Lista.Add(component);
        }

        public void Remove(IComponent component)
        {
            Lista.Remove(component);
        }

        public IComponent GetChild(int index)
        {
            return Lista[index];
        }

        public string ToString(IComponent component)
        {
            return ";";
        }

        public bool Equals(IComponent component)
        {
            return false;
        }

        public int Punteggio(IComponent component)
        {
            return 0;
        }

    }
}
