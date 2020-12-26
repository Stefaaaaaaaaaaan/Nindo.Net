using System;
using Nindo.Net.Models.Enums;

namespace Nindo.Net.Helpers
{
    internal static class SizeExtensions
    {
        internal static string ToApiString(this Size size)
        {
            return size switch
            {
                Size.Small => "small",
                Size.Big => "big",
                _ => throw new NotSupportedException("Invalid size type.")
            };
        }
    }
}