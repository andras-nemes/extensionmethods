using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace System
{
    public static class EnumExtensions
    {
        public static string ToUserFriendlyString(this Enum value)
        {
            return Enum.GetName(value.GetType(), value);
        }

        public static string GetDetailedDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToUserFriendlyString());
            DescriptionAttribute descriptionAttribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return descriptionAttribute == null ? value.ToUserFriendlyString() : descriptionAttribute.Description;
        }
    }
}