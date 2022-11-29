using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanAccess:DatabaseAccess
    {
        public string Checklogic(TaiKhoan taiKhoan)
        {
            string info = CheckLogicDTO(taiKhoan);
            return info;
        }

    }
}
