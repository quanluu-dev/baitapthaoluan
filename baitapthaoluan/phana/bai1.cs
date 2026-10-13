using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai1 : Form
    {
        private Label lblTieuDe;
        private Label lblBanKinh;
        private Label lblChuVi;
        private Label lblDienTich;
        private TextBox txtBanKinh;
        private TextBox txtChuVi;
        private TextBox txtDienTich;
        private Button btnTinh;
        private Button btnLamLai;

        public bai1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblBanKinh = new Label();
            this.lblChuVi = new Label();
            this.lblDienTich = new Label();
            this.txtBanKinh = new TextBox();
            this.txtChuVi = new TextBox();
            this.txtDienTich = new TextBox();
            this.btnTinh = new Button();
            this.btnLamLai = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 1 - Tính chu vi, diện tích hình tròn";
            this.ClientSize = new Size(480, 270);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH TRÒN";
            this.lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(20, 40, 80);
            this.lblTieuDe.Location = new Point(20, 20);
            this.lblTieuDe.Size = new Size(440, 35);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // lblBanKinh
            this.lblBanKinh.Text = "Bán kính";
            this.lblBanKinh.Location = new Point(60, 75);
            this.lblBanKinh.Size = new Size(90, 25);

            // txtBanKinh
            this.txtBanKinh.Location = new Point(160, 72);
            this.txtBanKinh.Size = new Size(240, 29);

            // lblChuVi
            this.lblChuVi.Text = "Chu vi";
            this.lblChuVi.Location = new Point(60, 118);
            this.lblChuVi.Size = new Size(90, 25);

            // txtChuVi
            this.txtChuVi.Location = new Point(160, 115);
            this.txtChuVi.Size = new Size(240, 29);
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.BackColor = Color.FromArgb(220, 235, 252);

            // lblDienTich
            this.lblDienTich.Text = "Diện tích";
            this.lblDienTich.Location = new Point(60, 160);
            this.lblDienTich.Size = new Size(90, 25);

            // txtDienTich
            this.txtDienTich.Location = new Point(160, 157);
            this.txtDienTich.Size = new Size(240, 29);
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.BackColor = Color.FromArgb(220, 235, 252);

            // btnTinh
            this.btnTinh.Text = "Tính";
            this.btnTinh.Location = new Point(130, 210);
            this.btnTinh.Size = new Size(100, 35);
            this.btnTinh.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTinh.ForeColor = Color.White;
            this.btnTinh.FlatStyle = FlatStyle.Flat;
            this.btnTinh.Click += new EventHandler(this.BtnTinh_Click);

            // btnLamLai
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Location = new Point(260, 210);
            this.btnLamLai.Size = new Size(100, 35);
            this.btnLamLai.BackColor = Color.FromArgb(108, 117, 125);
            this.btnLamLai.ForeColor = Color.White;
            this.btnLamLai.FlatStyle = FlatStyle.Flat;
            this.btnLamLai.Click += new EventHandler(this.BtnLamLai_Click);

            // Add controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblBanKinh);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnLamLai);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnTinh_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtBanKinh.Text.Trim(), out double r) || r <= 0)
            {
                MessageBox.Show("Vui lòng nhập bán kính r > 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBanKinh.Focus();
                txtBanKinh.SelectAll();
                return;
            }

            double chuVi = 2 * Math.PI * r;
            double dienTich = Math.PI * r * r;

            txtChuVi.Text = chuVi.ToString("F2");
            txtDienTich.Text = dienTich.ToString("F2");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtBanKinh.Focus();
        }
    }
}
