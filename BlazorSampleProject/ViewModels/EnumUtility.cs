using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace BlazorSampleProject.ViewModels
{
    public static class EnumUtility
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }
    }
}
