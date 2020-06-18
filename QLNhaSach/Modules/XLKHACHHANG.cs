using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaSach.Modules
{
    class XLKHACHHANG : XLBANG
    {
        public XLKHACHHANG() : base("KHACHHANG") { }
        public XLKHACHHANG(string pQuery) : base("KHACHHANG", pQuery) { }
    }
}
