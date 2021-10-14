using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AssemblyBrowser
{
    public class NamespaceDescription
    {
        public string Name { get; internal set; }
        internal NamespaceDescription parent;

        [JsonInclude]
        public List<NamespaceDescription> ChildNamespaces = new List<NamespaceDescription>();
        [JsonInclude]
        public List<ClassDescription> Classes = new List<ClassDescription>();

    }
}
