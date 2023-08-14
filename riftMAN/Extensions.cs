using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riftMAN;
internal static class Extensions
{
    public static string ToCSVString(this string[] input)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(input[i]);
            if (i < input.Length - 1) sb.Append(", ");
        }
        return sb.ToString();
    }
}
