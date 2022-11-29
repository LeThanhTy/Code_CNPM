using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string MaTK { set; get; }
        public string TK { set; get; }
        public string MK { set; get; }
        public int FK_MaQuyen { set; get; }

    }
}
