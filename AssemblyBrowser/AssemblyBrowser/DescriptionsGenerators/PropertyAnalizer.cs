using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyBrowser.DescriptionsGenerators
{
    class PropertyAnalizer
    {

        public PropertyDescription GeneratePropertyDescription(PropertyInfo propertyInfo)
        {
            PropertyDescription propertyDescription = new PropertyDescription();
            StringBuilder builder = new StringBuilder();
            this.GetPropertyMainInfo(propertyInfo,builder);
            propertyDescription.PropertySignature = builder.ToString();
            return propertyDescription;
        }

        private void GetPropertyMainInfo(PropertyInfo propertyInfo, StringBuilder builder)
        {
            builder.Append(ClassAnalizer.GetClassName(propertyInfo.PropertyType));
            builder.Append(" ");
            builder.Append(propertyInfo.Name);
            builder.Append(" {");

            if (propertyInfo.CanRead) 
            {
                builder.Append(" get; ");
            }
            if (propertyInfo.CanWrite)
            {
                builder.Append(" set; ");
            }

            builder.Append(" }");

        }


    }
}
