using DocumentModel;
using System.Reflection;

namespace FileIO
{
    public class ReflectionDocs
    {

        public static void GetDocs()
        {
            Console.WriteLine();

            using (StreamWriter writer = new StreamWriter("DocumentAttributes.txt"))
            {

                var assembly = Assembly.GetExecutingAssembly();

                writer.WriteLine(assembly);
                var types = assembly.GetTypes();


                foreach (Type type in types)
                {
                    var attributes = type.GetCustomAttributes(typeof(DocumentAttribute), true);

                    if (attributes.Length > 0)
                    {
                        if (type.IsClass)
                        {
                            writer.WriteLine("Class: " + type.Name);
                            writer.WriteLine("\tDescription: " + ((DocumentAttribute)attributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Description);
                            writer.WriteLine();


                            foreach (ConstructorInfo constructor in type.GetConstructors())
                            {
                                var constructorAttributes = constructor.GetCustomAttributes(typeof(DocumentAttribute), true);
                                if (constructorAttributes.Length > 0)
                                {
                                    writer.WriteLine("Constructor: " + constructor.Name);
                                    writer.WriteLine("\tDescription: " + ((DocumentAttribute)constructorAttributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Description);
                                    writer.WriteLine("\tInput: " + ((DocumentAttribute)constructorAttributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Input);
                                    writer.WriteLine();
                                }
                            }

                            foreach (MethodInfo method in type.GetMethods())
                            {
                                var methodAttributes = method.GetCustomAttributes(typeof(DocumentAttribute), true);
                                if (methodAttributes.Length > 0)
                                {
                                    writer.WriteLine("Method: " + method.Name);
                                    writer.WriteLine("\tDescription: " + ((DocumentAttribute)methodAttributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Description);
                                    writer.WriteLine("\tInput: " + ((DocumentAttribute)methodAttributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Input);
                                    writer.WriteLine("\tOutput: " + ((DocumentAttribute)methodAttributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Output);
                                    writer.WriteLine();
                                }
                            }

                            foreach (PropertyInfo property in type.GetProperties())
                            {
                                var propertyAttributes = property.GetCustomAttributes(typeof(DocumentAttribute), true);
                                if (propertyAttributes.Length > 0)
                                {
                                    writer.WriteLine("Property: " + property.Name);
                                    writer.WriteLine("\tDescription: " + ((DocumentAttribute)propertyAttributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Description);
                                    writer.WriteLine("\tOutput: " + ((DocumentAttribute)propertyAttributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Output);
                                    writer.WriteLine();
                                }
                            }

                        }

                        if (type.IsEnum)
                        {
                            writer.WriteLine("Enum: " + type.Name);
                            writer.WriteLine("\tDescription: " + ((DocumentAttribute)attributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Description);

                            string[] names = type.GetEnumNames();
                            foreach (string name in names)
                            {
                                writer.WriteLine(name);

                            }
                            writer.WriteLine();
                        }

                    }
                }


            }

        }
    }

    /*        public static async Task  GetDocs()
            {
                using (StreamWriter writer = new StreamWriter("DocumentAttributes.txt"))
                {
                    var assembly = Assembly.GetExecutingAssembly();


                    try
                    {
                        await writer.WriteLineAsync($"Assembly name: {assembly.FullName}");


                        Type[] types = assembly.GetTypes();

                        foreach (Type type in types)
                        {
                            ListType(type);
                            ListConstructors(type);
                            ListProperties(type);
                            ListFields(type);
                            ListMethods(type);
                        }
                    }
                    finally
                    {
                        writer.Close();
                        writer.Dispose();
                    }
                    Console.WriteLine("converting documents to text");
                }
            }
            public static async Task ListType(Type type)
            {
                using (StreamWriter writer = new StreamWriter("DocumentAttributes.txt"))
                {
                    var documentAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute), false);

                    if (documentAttribute != null && type.IsClass)
                    {
                        await writer.WriteLineAsync( $"\n Class: {type.Name} ");
                        await writer.WriteLineAsync( $"\n Description:{documentAttribute.Description} ");
                        //Console.WriteLine($"\n Class: {type.Name} ");
                        //Console.WriteLine($" Description:{documentAttribute.Description}  ");
                        await File.AppendAllTextAsync("DocumentAttributes.txt", "hello");
                    }
                    else if (documentAttribute != null && type.IsEnum)
                    {
                        File.AppendAllText("DocumentAttributes.txt", $"\n Enum: {type.Name} \n Description:{documentAttribute.Description} \n\t Input:{documentAttribute.Input}");

                    }
                    else if (documentAttribute != null && type.IsInterface)
                    {
                        File.AppendAllText("DocumentAttributes.txt", $"\n Interface: {type.Name} \n Description:{documentAttribute.Description} ");

                    }

                }
            }
            public static async Task ListConstructors(Type type)
            {
                var constructors = type.GetConstructors();
                foreach (var constructor in constructors)
                {
                    var documentattribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute), false);

                    if (documentattribute != null)
                    {
                       await File.AppendAllTextAsync("DocumentAttributes.txt", $"\n\t Constructor: {constructor.Name} \n\t\t Description:{documentattribute.Description} \n\t\t Input:{documentattribute.Input} \n\t\t Output:{documentattribute.Output}");
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

                        File.AppendAllText("DocumentAttributes.txt", $"\n\t Methods: {method.Name} \n\t\t Description:{documentattribute.Description} \n\t\t Input:{documentattribute.Input} \n\t\t Output:{documentattribute.Output}");
                    }
                }
            }
            public static void   ListProperties(Type type)
            {
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    var documentattribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute), false);

                    if (documentattribute != null)
                    {

                         File.AppendAllText("DocumentAttributes.txt", $"\n\t Properties: {property.Name} \n\t\t Description:{documentattribute.Description} \n\t\t Input:{documentattribute.Input} \n\t\t Output:{documentattribute.Output}");
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
            }*/

}
