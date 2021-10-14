using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.DescriptionsGenerators
{
    internal class NamespaceAnalizer
    {
        public NamespaceDescription GetParentNamespace(string Namespace, List<NamespaceDescription> namespaces)
        {
            NamespaceDescription result = null;
            foreach (NamespaceDescription description in namespaces)
            {
                if (Namespace.Contains(description.Name))
                {
                    result = this.GetParentNamespace(Namespace, description.ChildNamespaces);
                    if (result == null )
                    {
                        result = description;
                       
                    }
                    return result;
                }
            }
            return result;
        }

        public NamespaceDescription GenerateNamespaceDescription(string name, NamespaceDescription parentNamespace)
        {
            NamespaceDescription description = new NamespaceDescription();
            description.Name = name;
            description.parent = parentNamespace;
            return description;
        }
        

    }
}
