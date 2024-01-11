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
        void Add(Component component);

        void Remove(Component component);
    }
}