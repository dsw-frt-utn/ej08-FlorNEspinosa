using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_n_6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
