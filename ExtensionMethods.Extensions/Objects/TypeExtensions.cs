namespace System
{
    public static class TypeExtensions
    {
        public static string GetTypeMetadata(this Type target)
        {
            return string.Concat("Assembly: ", target.AssemblyQualifiedName, ", name: ", target.FullName);
        }
    }
}