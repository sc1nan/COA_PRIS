using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS.Utilities
{
    internal class Util
    {
        public string generate_ID(string id)
        {

            int numeric_Index = id.IndexOfAny("0123456789".ToCharArray());

            if (numeric_Index != -1)
            {

                string prefix = id.Substring(0, numeric_Index);

                string numericSuffix = id.Substring(numeric_Index);

                int numericValue = int.Parse(numericSuffix) + 1;

                string newNumericSuffix = numericValue.ToString("D" + numericSuffix.Length);

                return prefix + newNumericSuffix;
            }
            else
                return "err";

        }
        public string generate_ID(string id, string num)
        {
            return "";
        }
    }
}
