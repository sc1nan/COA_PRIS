using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS.UserControlUtil.Jesser_Util
{
    internal interface IGenericTableVariables
    {
        int min_lim { get; set; }
        int page_cnt { get; set; }
        string[] table_names { get; }

    }
}
