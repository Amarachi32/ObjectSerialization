using DocumentModel;
using System.Reflection;

namespace FileIO
{
    public class TextDocs
    {

        public static string GetDocs()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();


            string documentation = "";


            foreach (var type in types)
            {

                if (type.IsClass)
                {

                    var typeAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                    if (typeAttribute != null)
                    {
                        documentation += "Class: " + type.Name + "\n";

                        documentation += "Description: " + typeAttribute.Description + "\n";

                        documentation += "Input: " + typeAttribute.Input + "\n";

                        documentation += "Output: " + typeAttribute.Output + "\n\n";
                    }


                    var constructors = type.GetConstructors();


                    foreach (var constructor in constructors)
                    {

                        var constructorAttribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute));

                        if (constructorAttribute != null)
                        {
                            documentation += "Constructor: " + constructor.Name + "\n";

                            documentation += "Description: " + constructorAttribute.Description + "\n";

                            documentation += "Input: " + constructorAttribute.Input + "\n";

                            documentation += "Output: " + constructorAttribute.Output + "\n\n";
                        }
                    }


                    var properties = type.GetProperties();


                    foreach (var property in properties)
                    {

                        var propertyAttribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute));

                        // If the property has the DocumentAttribute, add its documentation to the string

                        if (propertyAttribute != null)
                        {
                            documentation += "Property: " + property.Name + "\n";

                            documentation += "Description: " + propertyAttribute.Description + "\n";

                            documentation += "Input: " + propertyAttribute.Input + "\n";

                            documentation += "Output: " + propertyAttribute.Output + "\n\n";
                        }
                    }

                    var fields = type.GetFields();
                    foreach (var field in fields)
                    {
                        var documentattribute = (DocumentAttribute)field.GetCustomAttribute(typeof(DocumentAttribute), false);

                        if (documentattribute != null)
                        {

                            Console.WriteLine($"\n\t Fields: {field.Name} \n\t\t Description:{documentattribute.Description} ");
                        }
                    }
                }

                else if (type.IsEnum)
                {
                    var typeattribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                    if (typeattribute != null)
                    {
                        documentation += "Enum: " + type.Name + "\n";

                        documentation += "Description: " + typeattribute.Description + "\n\n\n";
                    }
                }

                else if (type.IsInterface)
                {
                    documentation += "Interface: " + type.Name + "\n\n";
                }
            }


            return documentation;
        }
    }

}



