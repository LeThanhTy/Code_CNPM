using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
         public string Checklogic(TaiKhoan taikhoan)
        {
            // Kiểm tra Nhap liệu 
            if(taikhoan.TK == "")
            {
                return "requeid_taikhoan";
            }
            if(taikhoan.MK == "")
            {
                return "requeid_password";
            }
            string info = tkAccess.Checklogic(taikhoan);
            return info;
        }
            }
}
