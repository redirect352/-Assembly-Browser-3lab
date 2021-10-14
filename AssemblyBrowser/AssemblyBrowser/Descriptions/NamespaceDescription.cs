using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser
{
    class NamespaceDescription
    {
        public string Name { get; internal set; }
        internal NamespaceDescription parent;
        public List<NamespaceDescription> ChildNamespaces = new List<NamespaceDescription>();
        public List<ClassDescription> Classes = new List<ClassDescription>();

    }
}
