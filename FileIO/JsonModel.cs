namespace FileIO
{
    public class JsonModel
    {
 
            public string Name { get; set; }
            public string Description { get; set; }
            public MethodFormat Constructors { get; set; }
            public List<PropertyFormat> Properties { get; set; }
            public List<MethodFormat> Methods { get; set; }
            public List<EnumsFormat> Enums { get; internal set; }

            public JsonModel()
            {
                Properties = new();
                Methods = new();
                Enums = new();
            }
        }

        public class PropertyFormat
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Input { get; set; }
            public string Output { get; set; }
        }

        public class MethodFormat : PropertyFormat { }

        public class EnumsFormat : PropertyFormat { }


    
}
