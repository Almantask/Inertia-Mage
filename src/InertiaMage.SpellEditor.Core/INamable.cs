using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaMage.SpellEditor.Core
{
    interface INamableGet
    {
        string Name { get; }
    }

    interface INamableSet
    {
        string Name { set; }
    }
}
