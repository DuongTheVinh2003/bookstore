using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public class SachBLL
    {
        private static SachDAL sachDAL = new SachDAL(); // Biến thành static

        public static void AddSach(SachDTO sach) // Biến thành static
        {
            sachDAL.AddSach(sach);
        }

        public static DataTable GetAllSachByMaLoai(int maLoai)
        {
            return SachDAL.GetAllSachByMaLoai(maLoai);
        }

        public static DataTable GetAllLoaiSach()
        {
            return sachDAL.GetAllLoaiSach();
        }

        public static void UpdateSach(SachDTO sach)
        {
            sachDAL.UpdateSach(sach);
        }

        public static void DeleteSach(string maSach)
        {
            sachDAL.DeleteSach(maSach);
        }
        public static bool CheckMaSachExists(string maSach)
        {
            DataTable dt = SachDAL.GetAllSachByMaLoai(0); // Lấy tất cả sách (có thể cần sửa query để lấy tất cả sách)
            foreach (DataRow row in dt.Rows)
            {
                if (row["MaSach"].ToString() == maSach)
                {
                    return true; // MaSach đã tồn tại
                }
            }
            return false; // MaSach chưa tồn tại
        }
    }
}
