// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GruntTaskingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GruntTaskingType
    {
        [EnumMember(Value = "Assembly")]
        Assembly,
        [EnumMember(Value = "Set")]
        Set,
        [EnumMember(Value = "Kill")]
        Kill
    }
    internal static class GruntTaskingTypeEnumExtension
    {
        internal static string ToSerializedValue(this GruntTaskingType? value)
        {
            return value == null ? null : ((GruntTaskingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GruntTaskingType value)
        {
            switch( value )
            {
                case GruntTaskingType.Assembly:
                    return "Assembly";
                case GruntTaskingType.Set:
                    return "Set";
                case GruntTaskingType.Kill:
                    return "Kill";
            }
            return null;
        }

        internal static GruntTaskingType? ParseGruntTaskingType(this string value)
        {
            switch( value )
            {
                case "Assembly":
                    return GruntTaskingType.Assembly;
                case "Set":
                    return GruntTaskingType.Set;
                case "Kill":
                    return GruntTaskingType.Kill;
            }
            return null;
        }
    }
}
