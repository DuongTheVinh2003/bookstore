using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SachDAL
    {
        private static string connectionString = "Data Source=MSI;Initial Catalog=BookStore;Integrated Security=True;";

        public static DataTable GetAllSachByMaLoai(int maLoai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaSach, TieuDe, Gia, SoLuong FROM Sach WHERE MaLoai = @MaLoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllLoaiSach()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaLoai, TenLoai FROM LoaiSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddSach(SachDTO sach)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Sach (MaSach, TieuDe, Gia, SoLuong, MaLoai) VALUES (@MaSach, @TieuDe, @Gia, @SoLuong, @MaLoai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                cmd.Parameters.AddWithValue("@TieuDe", sach.TieuDe);
                cmd.Parameters.AddWithValue("@Gia", sach.Gia);
                cmd.Parameters.AddWithValue("@SoLuong", sach.SoLuong);
                cmd.Parameters.AddWithValue("@MaLoai", sach.MaLoai);
                
                
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSach(SachDTO sach)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Sach SET TieuDe = @TieuDe, Gia = @Gia, SoLuong = @SoLuong, MaLoai = @MaLoai WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                cmd.Parameters.AddWithValue("@TieuDe", sach.TieuDe);
                cmd.Parameters.AddWithValue("@Gia", sach.Gia);
                cmd.Parameters.AddWithValue("@SoLuong", sach.SoLuong);
                cmd.Parameters.AddWithValue("@MaLoai", sach.MaLoai);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSach(string maSach)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Sach WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
