namespace System
{
    public static class ObjectExtensions
    {
        public static string ToXmlRepresentation(this object target)
        {
            return string.Concat("<xml>", target.ToString(), "</xml>");
        }
    }
}