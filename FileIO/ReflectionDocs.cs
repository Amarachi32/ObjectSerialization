using DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class ReflectionDocs
    {
        public static void GetDocs()
        {
            var assembly = Assembly.GetExecutingAssembly();


            Console.WriteLine($"Assembly name: {assembly.FullName}");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                ListType(type);
                //Console.WriteLine("******************************");
                ListConstructors(type);
                //Console.WriteLine("******************************");
                ListProperties(type);
                ListFields(type);
                //Console.WriteLine("******************************");
                ListMethods(type);
                //Console.WriteLine("******************************");
                //Console.WriteLine();

            }

        }
        public static void ListType(Type type)
        {
            var documentAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute), false);

            if (documentAttribute != null && type.IsClass)
            {

                Console.WriteLine($"\n Class: {type.Name} ");
                Console.WriteLine($" Description:{documentAttribute.Description}  ");

            }
            else if (documentAttribute != null && type.IsEnum)
            {
                Console.WriteLine($"\n Enum: {type.Name} \n Description:{documentAttribute.Description} \n\t Input:{documentAttribute.Input}");

            }
            else if (documentAttribute != null && type.IsInterface)
            {
                Console.WriteLine($"\n Interface: {type.Name} \n Description:{documentAttribute.Description} ");

            }


        }
        public static void ListConstructors(Type type)
        {
            var constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                var documentattribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute), false);

                if (documentattribute != null)
                {

                    Console.WriteLine($"\n\t Constructor: {constructor.Name} \n\t\t Description:{documentattribute.Description} \n\t\t Input:{documentattribute.Input} \n\t\t Output:{documentattribute.Output}");
                }
            }

        }
        public static void ListMethods(Type type)
        {
            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                var documentattribute = (DocumentAttribute)method.GetCustomAttribute(typeof(DocumentAttribute), false);

                if (documentattribute != null)
                {

                    Console.WriteLine($"\n\t Methods: {method.Name} \n\t\t Description:{documentattribute.Description} \n\t\t Input:{documentattribute.Input} \n\t\t Output:{documentattribute.Output}");
                }
            }
        }
        public static void ListProperties(Type type)
        {
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var documentattribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute), false);

                if (documentattribute != null)
                {

                    Console.WriteLine($"\n\t Properties: {property.Name} \n\t\t Description:{documentattribute.Description} \n\t\t Input:{documentattribute.Input} \n\t\t Output:{documentattribute.Output}");
                }
            }
        }

        public static void ListFields(Type type)
        {
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
    }
}
