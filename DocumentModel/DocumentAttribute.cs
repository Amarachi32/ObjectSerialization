namespace DocumentModel
{
    [AttributeUsage(AttributeTargets.All | AttributeTargets.Enum, Inherited = false, AllowMultiple = true)]
    public class DocumentAttribute : Attribute
    {
        public DocumentAttribute(string description)
        {
            Description = description;
        }

        public DocumentAttribute(string description, string input = "", string output = "")
        {
            Description = description;
            Input = input;
            Output = output;
        }

        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

    }
}