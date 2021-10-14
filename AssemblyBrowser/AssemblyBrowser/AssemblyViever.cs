using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AssemblyBrowser.DescriptionsGenerators;

namespace AssemblyBrowser
{
    public class AssemblyViever
    {
        List<NamespaceDescription> namespaces = new List<NamespaceDescription>();

        public String AssemblyName { get; private set; }

        public void VievAssembly()
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); 
            Type[] types = assembly.GetTypes();
            NamespaceAnalizer analizer = new NamespaceAnalizer();
            ClassAnalizer classAnalizer = new ClassAnalizer();

            NamespaceDescription parent, current;
            ClassDescription currentClass;

            foreach (Type type in types)
            {
                if (!type.IsClass)
                    continue;

                parent = analizer.GetParentNamespace(type.Namespace, namespaces);
                current = analizer.GenerateNamespaceDescription(type.Namespace, parent);
                if (parent == null)
                {
                    namespaces.Add(current);
                }
                else if (parent.Name != current.Name)
                {
                    parent.ChildNamespaces.Add(current);
                }
                else {
                    current = parent;
                }

                currentClass = classAnalizer.GenerateClassDescription(type);
                current.Classes.Add(currentClass);
            }
            string end = "";
            end = "fweef";
        }


    }
}
