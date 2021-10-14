using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyBrowser
{
    class ClassDescription
    {
        public String Name { get; internal set; }
        public ClassDescription parentClass = null;
        internal List<ClassDescription> childClasses = new List<ClassDescription>();   
        internal List<MethodDectription> methods = new List<MethodDectription>();
        internal List<PropertyDescription> properties = new List<PropertyDescription>();
        internal List<FieldDesctription> fieldDesctriptions = new List<FieldDesctription>();

        public ClassDescription()
        {
     
        }
 
    }
}
