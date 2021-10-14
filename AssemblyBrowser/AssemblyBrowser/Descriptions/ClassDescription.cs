using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json.Serialization;

namespace AssemblyBrowser
{
    public class ClassDescription
    {
        [JsonPropertyName("")]
        public String Name { get; internal set; }
        public ClassDescription parentClass = null;
        internal List<ClassDescription> childClasses = new List<ClassDescription>();   
        
        [JsonInclude]
        public List<MethodDectription> methods = new List<MethodDectription>();
        [JsonInclude]

        public List<PropertyDescription> properties = new List<PropertyDescription>();
        [JsonInclude]

        public List<FieldDesctription> fields = new List<FieldDesctription>();

        public ClassDescription()
        {
     
        }
 
    }
}
