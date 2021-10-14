using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.DescriptionsGenerators
{
    class ClassAnalizer
    {
        public ClassDescription GenerateClassDescription(Type thisClass)
        {
            ClassDescription description = new ClassDescription();
            description.Name = thisClass.Name;
            

            return description;
        }
    }
}
