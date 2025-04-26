namespace thongtinsach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvSach = new DataGridView();
            txtMasach = new TextBox();
            txtTieude = new TextBox();
            txtSoluong = new TextBox();
            txtGia = new TextBox();
            btnadd = new Button();
            btnedit = new Button();
            btnsave = new Button();
            btndel = new Button();
            btncancel = new Button();
            cboLoaiSach = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 160);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiêu đề";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 160);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 91);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 4;
            label5.Text = "Giá";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(25, 201);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(721, 183);
            dgvSach.TabIndex = 5;
            dgvSach.CellContentClick += dgvSach_CellContentClick;
            // 
            // txtMasach
            // 
            txtMasach.Location = new Point(111, 88);
            txtMasach.Name = "txtMasach";
            txtMasach.Size = new Size(125, 27);
            txtMasach.TabIndex = 6;
            txtMasach.TextChanged += txtMasach_TextChanged;
            // 
            // txtTieude
            // 
            txtTieude.Location = new Point(111, 153);
            txtTieude.Name = "txtTieude";
            txtTieude.Size = new Size(125, 27);
            txtTieude.TabIndex = 7;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(492, 153);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(125, 27);
            txtSoluong.TabIndex = 8;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(492, 91);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(125, 27);
            txtGia.TabIndex = 9;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(83, 400);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 10;
            btnadd.Text = "Thêm";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(220, 400);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 29);
            btnedit.TabIndex = 11;
            btnedit.Text = "sửa";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(364, 400);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 12;
            btnsave.Text = "Lưu";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            btndel.Location = new Point(506, 400);
            btndel.Name = "btndel";
            btndel.Size = new Size(94, 29);
            btndel.TabIndex = 13;
            btndel.Text = "Xóa";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(652, 400);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 14;
            btncancel.Text = "Bỏ qua";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // cboLoaiSach
            // 
            cboLoaiSach.FormattingEnabled = true;
            cboLoaiSach.Location = new Point(111, 33);
            cboLoaiSach.Name = "cboLoaiSach";
            cboLoaiSach.Size = new Size(151, 28);
            cboLoaiSach.TabIndex = 16;
            cboLoaiSach.SelectedIndexChanged += cboLoaiSach_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboLoaiSach);
            Controls.Add(btncancel);
            Controls.Add(btndel);
            Controls.Add(btnsave);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(txtGia);
            Controls.Add(txtSoluong);
            Controls.Add(txtTieude);
            Controls.Add(txtMasach);
            Controls.Add(dgvSach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Thông tin sách";
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvSach;
        private TextBox txtMasach;
        private TextBox txtTieude;
        private TextBox txtSoluong;
        private TextBox txtGia;
        private Button btnadd;
        private Button btnedit;
        private Button btnsave;
        private Button btndel;
        private Button btncancel;
        private ComboBox cboLoaiSach;
    }
}
