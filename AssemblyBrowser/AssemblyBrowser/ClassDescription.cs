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

        private List<ClassDescription> childClasses = new List<ClassDescription>();
        public ClassDescription parentClass = null;

        private List<MethodDectription> methods = new List<MethodDectription>();
        private List<PropertyDescription> properties = new List<PropertyDescription>();
        private List<FieldDesctription> fieldDesctriptions = new List<FieldDesctription>();

        public ClassDescription( Type type, ClassDescription parent)
        {

            parentClass = parent;


            type.GetMethods();
          


        }
 



    }
}
