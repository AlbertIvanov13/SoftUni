namespace AuthorProblem
{
    [Author("Victor")]
    public class StartUp
    {
        [Author("George")]
        public static void Main(string[] args)
        {

        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}