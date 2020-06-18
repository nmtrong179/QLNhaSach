using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaSach.Modules
{
    class XLNHANVIEN : XLBANG
    {
        public XLNHANVIEN() : base("NHANVIEN") { }
        public XLNHANVIEN(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}
