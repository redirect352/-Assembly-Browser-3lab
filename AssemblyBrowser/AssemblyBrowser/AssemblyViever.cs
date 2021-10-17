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
        private List<NamespaceDescription> namespaces1 = new List<NamespaceDescription>();

      
        public List<NamespaceDescription> namespaces { get { return namespaces1; } }

        public string AssemblyName { get; private set; }

        public void VievAssembly( string path )
        {
            this.CloseAssembly();
            Assembly assembly =Assembly.LoadFrom(path); 
            Type[] types = assembly.GetTypes();
            NamespaceAnalizer analizer = new NamespaceAnalizer();
            ClassAnalizer classAnalizer = new ClassAnalizer();

            NamespaceDescription parent, current;
            ClassDescription currentClass;

            foreach (Type type in types)
            {
                if (!type.IsClass)
                    continue;

                current = namespaces.Find((NamespaceDescription description) => (description.Name == type.Namespace));
                if (  current == null ) 
                {
                    current = analizer.GenerateNamespaceDescription(type.Namespace);
                    namespaces.Add(current);
                } 
                     
                currentClass = classAnalizer.GenerateClassDescription(type);
                current.Classes.Add(currentClass);
            }
        }

        public void CloseAssembly()
        {
            namespaces1 = new List<NamespaceDescription>();
            AssemblyName = "";

        }

    }
}
