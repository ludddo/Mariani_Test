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
        protected List<Component> _children = new List<Component>();

        public void Add(Component component)
        {
            this._children.Add(component);
        }

        public void Remove(Component component)
        {
            this._children.Remove(component);
        }

    }
}
