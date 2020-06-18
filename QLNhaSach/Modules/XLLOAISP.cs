using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaSach.Modules
{
    class XLLOAISP : XLBANG
    {
        public XLLOAISP() : base("LOAISP") { }
        public XLLOAISP(string pQuery) : base("LOAISP", pQuery) { }
    }
}
