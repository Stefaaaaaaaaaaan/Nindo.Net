using System;
using Nindo.Net.Models.Enums;

namespace Nindo.Net.Helpers
{
    internal static class SizeExtensions
    {
        internal static string ToApiString(this Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return "small";
                case Size.Big:
                    return "big";
                default:
                    throw new NotSupportedException("Invalid size type.");
            }
        }
    }
}