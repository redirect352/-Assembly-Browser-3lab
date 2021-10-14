using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyBrowser.DescriptionsGenerators
{
    class FieldAnalizer
    {

        public FieldDesctription GetFieldDesctription(FieldInfo fieldInfo)
        {
            FieldDesctription desctription = new FieldDesctription();
            StringBuilder builder = new StringBuilder();
            this.GetFieldModifiers(fieldInfo, builder);
            this.GetFieldMainInfo(fieldInfo, builder);
            desctription.Name = builder.ToString();
            return desctription;
        }

        private void GetFieldMainInfo(FieldInfo fieldInfo, StringBuilder builder) 
        {
            builder.Append( ClassAnalizer.GetClassName(fieldInfo.FieldType));
            builder.Append(" ");
            builder.Append(fieldInfo.Name);
            builder.Append(" ");
        }

        private void GetFieldModifiers(FieldInfo fieldInfo, StringBuilder builder)
        {
            if (fieldInfo.IsPublic)
            {
                builder.Append("public");
                builder.Append(" ");
            } else if (fieldInfo.IsPrivate)
            {
                builder.Append("private");
                builder.Append(" ");
            }

            if (fieldInfo.IsStatic)
            {
                builder.Append("static");
            }
            
        }

    }
}
