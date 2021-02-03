using System.Runtime.Serialization;

namespace Nindo.Net.Models.Enums
{
    public enum Size
    {
        [EnumMember(Value = "small")]
        Small = 0,

        [EnumMember(Value = "big")]
        Big = 1
    }
}