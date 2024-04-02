using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class TimeConversion
    {
        public string Conversion(string s)
        {
            DateTime time = DateTime.ParseExact(s, "hh:mm:sstt", System.Globalization.CultureInfo.InvariantCulture);
            return time.ToString("HH:mm:ss");
        }
    }
}
