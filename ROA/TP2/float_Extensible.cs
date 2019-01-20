using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROA.TP2
{
    static class float_Extensible
    {
        public static bool IsInfinity(this float f)
    {
        return float.IsInfinity(f) || f < 0;
    }
}}