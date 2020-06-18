using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaSach.Modules
{
    class XLLOAITK : XLBANG
    {
        public XLLOAITK() : base("LOAITK") { }
        public XLLOAITK(string pQuery) : base("LOAITK", pQuery) { }
    }
}
