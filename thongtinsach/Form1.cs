using BLL;
using DTO;
using System.Data;

namespace thongtinsach
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private SachBLL sachBLL = new SachBLL();
        private System.Data.DataTable dtSach;
        private int currentMaLoai;
        public Form1()
        {
            InitializeComponent();
            LoadLoaiSach();
            LoadSach();

            cboLoaiSach.SelectedIndexChanged += new System.EventHandler(cboLoaiSach_SelectedIndexChanged);
            dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvSach_CellContentClick); // Thay đổi sự kiện
            btnadd.Click += new System.EventHandler(btnadd_Click);
            btnedit.Click += new System.EventHandler(btnedit_Click);
            btndel.Click += new System.EventHandler(btndel_Click);
            btncancel.Click += new System.EventHandler(btncancel_Click);
        }
        private void LoadLoaiSach()
        {
            System.Data.DataTable dtLoaiSach = SachBLL.GetAllLoaiSach();
            cboLoaiSach.DataSource = dtLoaiSach;
            cboLoaiSach.DisplayMember = "TenLoai";
            cboLoaiSach.ValueMember = "MaLoai";
        }
        private void LoadSach()
        {
            if (cboLoaiSach.SelectedValue != null)
            {
                // Lấy giá trị MaLoai từ SelectedValue
                var selectedValue = cboLoaiSach.SelectedValue;

                // Kiểm tra kiểu của SelectedValue
                if (selectedValue is DataRowView rowView)
                {
                    currentMaLoai = Convert.ToInt32(rowView["MaLoai"]); // Lấy giá trị của cột MaLoai
                }
                else
                {
                    currentMaLoai = Convert.ToInt32(selectedValue); // Nếu không phải DataRowView, thử chuyển đổi trực tiếp
                }

                dtSach = SachBLL.GetAllSachByMaLoai(currentMaLoai);
                dgvSach.DataSource = dtSach;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng nhấp vào một hàng hợp lệ
            {
                System.Windows.Forms.DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtMasach.Text = row.Cells["MaSach"].Value.ToString();
                txtTieude.Text = row.Cells["TieuDe"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
                txtSoluong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        private void txtMasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = txtMasach.Text;

                // Kiểm tra MaSach đã tồn tại chưa
                if (SachBLL.CheckMaSachExists(maSach))
                {
                    MessageBox.Show($"Mã sách {maSach} đã tồn tại. Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SachDTO sach = new SachDTO
                {
                    MaSach = maSach,
                    TieuDe = txtTieude.Text,
                    Gia = Convert.ToDecimal(txtGia.Text),
                    SoLuong = Convert.ToInt32(txtSoluong.Text),
                    MaLoai = currentMaLoai
                };
                SachBLL.AddSach(sach);
                LoadSach();
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SachDTO sach = new SachDTO
            {
                MaSach = txtMasach.Text,
                TieuDe = txtTieude.Text,
                Gia = Convert.ToDecimal(txtGia.Text),
                SoLuong = Convert.ToInt32(txtSoluong.Text),
                MaLoai = currentMaLoai
            };
            SachBLL.UpdateSach(sach);
            LoadSach();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string maSach = txtMasach.Text;
            SachBLL.DeleteSach(maSach);
            LoadSach();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtMasach.Clear();
            txtTieude.Clear();
            txtGia.Clear();
            txtSoluong.Clear();
        }
    }
}
