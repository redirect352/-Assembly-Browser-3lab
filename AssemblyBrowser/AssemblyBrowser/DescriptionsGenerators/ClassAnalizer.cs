using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyBrowser.DescriptionsGenerators
{
    class ClassAnalizer
    {
        public ClassDescription GenerateClassDescription(Type thisClass)
        {
            ClassDescription description = new ClassDescription();
            description.Name = thisClass.Name;

            this.GetMethodsDescriptions(thisClass,description);
            this.GetFieldsDescriptions(thisClass, description);
            this.GetPropertiesDescriptions(thisClass,description);
         
            return description;
        }

        public static string GetClassName(Type type)
        {
            if (!type.IsGenericType)
            {
                return type.Name;
            }
            else
            {

                string classname = "",
                    genericName = type.GetGenericTypeDefinition().Name;

                if (genericName.IndexOf("`") >= 0)
                {
                    genericName = genericName.Substring(0, genericName.IndexOf("`"));
                }

                classname += genericName;
                classname += '<';
                int i = 0;
                foreach (Type genericParameterType in type.GetGenericArguments())
                {
                    if (i > 0)
                    {
                        classname += ", ";
                    }
                    classname += ClassAnalizer.GetClassName(genericParameterType);
                    i++;
                }

                classname += '>';
                return classname;
            }

        }

        private void GetMethodsDescriptions( Type type, ClassDescription classDescription) 
        {
            MethodAnalizer methodAnalizer = new MethodAnalizer();

            foreach (MethodInfo info in type.GetMethods())
            {

                classDescription.methods.Add(methodAnalizer.GenerateMethodDescription(info));
            }
        }

        private void GetPropertiesDescriptions(Type type, ClassDescription classDescription)
        {
            PropertyAnalizer propertyAnalizer = new PropertyAnalizer();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                classDescription.properties.Add(propertyAnalizer.GeneratePropertyDescription(propertyInfo));
            }


        }

        private void GetFieldsDescriptions(Type type, ClassDescription classDescription)
        {
            FieldAnalizer fieldAnalizer = new FieldAnalizer();
            foreach (FieldInfo fieldInfo in type.GetFields())
            {
                classDescription.fields.Add(fieldAnalizer.GetFieldDesctription(fieldInfo));
            }
        }

    }
}
