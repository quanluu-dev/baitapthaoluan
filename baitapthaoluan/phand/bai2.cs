using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitapthaoluan.phand
{
    public class bai2 : Form
    {
        private Label lblMangGoc;
        private TextBox txtMangGoc;

        private Label lblKetQua;
        private TextBox txtKetQua;

        private Button btnXuatNgauNhien;
        private Button btnDemSoLe;
        private Button btnTimMin;
        private Button btnTongSoLe;
        private Button btnSapXepTang;
        private Button btnThoat;

        private int[] mangSo = Array.Empty<int>();

        public bai2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblMangGoc = new Label();
            this.txtMangGoc = new TextBox();

            this.lblKetQua = new Label();
            this.txtKetQua = new TextBox();

            this.btnXuatNgauNhien = new Button();
            this.btnDemSoLe = new Button();
            this.btnTimMin = new Button();
            this.btnTongSoLe = new Button();
            this.btnSapXepTang = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài D2 - Dãy số (Tìm Min/Max - Sắp xếp)";
            this.ClientSize = new Size(540, 260);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 244, 250);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // Mảng gốc
            this.lblMangGoc.Text = "Mảng gốc";
            this.lblMangGoc.Location = new Point(30, 25);
            this.lblMangGoc.Size = new Size(90, 25);

            this.txtMangGoc.Location = new Point(130, 22);
            this.txtMangGoc.Size = new Size(370, 29);
            this.txtMangGoc.ReadOnly = true;
            this.txtMangGoc.BackColor = Color.White;

            // Kết quả
            this.lblKetQua.Text = "Kết quả";
            this.lblKetQua.Location = new Point(30, 68);
            this.lblKetQua.Size = new Size(90, 25);

            this.txtKetQua.Location = new Point(130, 65);
            this.txtKetQua.Size = new Size(370, 29);
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.BackColor = Color.White;

            // 6 Buttons
            int col1X = 70;
            int col2X = 280;
            int btnW = 190;
            int btnH = 34;

            int row1Y = 115;
            int row2Y = 155;
            int row3Y = 195;

            this.btnXuatNgauNhien.Text = "Xuất ngẫu nhiên";
            this.btnXuatNgauNhien.Location = new Point(col1X, row1Y);
            this.btnXuatNgauNhien.Size = new Size(btnW, btnH);
            this.btnXuatNgauNhien.BackColor = Color.FromArgb(235, 240, 245);
            this.btnXuatNgauNhien.Click += new EventHandler(this.BtnXuatNgauNhien_Click);

            this.btnDemSoLe.Text = "Đếm các số lẻ";
            this.btnDemSoLe.Location = new Point(col1X, row2Y);
            this.btnDemSoLe.Size = new Size(btnW, btnH);
            this.btnDemSoLe.BackColor = Color.FromArgb(235, 240, 245);
            this.btnDemSoLe.Click += new EventHandler(this.BtnDemSoLe_Click);

            this.btnTimMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnTimMin.Location = new Point(col1X, row3Y);
            this.btnTimMin.Size = new Size(btnW, btnH);
            this.btnTimMin.BackColor = Color.FromArgb(235, 240, 245);
            this.btnTimMin.Click += new EventHandler(this.BtnTimMin_Click);

            this.btnTongSoLe.Text = "Tổng các số lẻ";
            this.btnTongSoLe.Location = new Point(col2X, row1Y);
            this.btnTongSoLe.Size = new Size(btnW, btnH);
            this.btnTongSoLe.BackColor = Color.FromArgb(235, 240, 245);
            this.btnTongSoLe.Click += new EventHandler(this.BtnTongSoLe_Click);

            this.btnSapXepTang.Text = "Sắp xếp tăng";
            this.btnSapXepTang.Location = new Point(col2X, row2Y);
            this.btnSapXepTang.Size = new Size(btnW, btnH);
            this.btnSapXepTang.BackColor = Color.FromArgb(235, 240, 245);
            this.btnSapXepTang.Click += new EventHandler(this.BtnSapXepTang_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(col2X, row3Y);
            this.btnThoat.Size = new Size(btnW, btnH);
            this.btnThoat.BackColor = Color.FromArgb(235, 240, 245);
            this.btnThoat.Click += new EventHandler(this.BtnThoat_Click);

            // Add Controls
            this.Controls.Add(this.lblMangGoc);
            this.Controls.Add(this.txtMangGoc);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnXuatNgauNhien);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnTimMin);
            this.Controls.Add(this.btnTongSoLe);
            this.Controls.Add(this.btnSapXepTang);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnXuatNgauNhien_Click(object? sender, EventArgs e)
        {
            Random rand = new Random();
            int n = 10;
            mangSo = new int[n];
            for (int i = 0; i < n; i++)
            {
                mangSo[i] = rand.Next(1, 100);
            }
            txtMangGoc.Text = string.Join("  ", mangSo);
            txtKetQua.Clear();
        }

        private void BtnDemSoLe_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int dem = 0;
            foreach (int x in mangSo)
            {
                if (x % 2 != 0) dem++;
            }
            txtKetQua.Text = $"Số phần tử lẻ: {dem}";
        }

        private void BtnTimMin_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int min = mangSo[0];
            foreach (int x in mangSo)
            {
                if (x < min) min = x;
            }
            txtKetQua.Text = $"Phần tử nhỏ nhất: {min}";
        }

        private void BtnTongSoLe_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int tongLe = 0;
            foreach (int x in mangSo)
            {
                if (x % 2 != 0) tongLe += x;
            }
            txtKetQua.Text = $"Tổng các số lẻ: {tongLe}";
        }

        private void BtnSapXepTang_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int[] sapXep = (int[])mangSo.Clone();
            Array.Sort(sapXep);
            txtKetQua.Text = string.Join("  ", sapXep);
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
