using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai2 : Form
    {
        private Label lblTieuDe;
        private Label lblChieuDai;
        private Label lblChieuRong;
        private Label lblChuVi;
        private Label lblDienTich;
        private TextBox txtChieuDai;
        private TextBox txtChieuRong;
        private TextBox txtChuVi;
        private TextBox txtDienTich;
        private Button btnTinh;
        private Button btnLamLai;

        public bai2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblChieuDai = new Label();
            this.lblChieuRong = new Label();
            this.lblChuVi = new Label();
            this.lblDienTich = new Label();
            this.txtChieuDai = new TextBox();
            this.txtChieuRong = new TextBox();
            this.txtChuVi = new TextBox();
            this.txtDienTich = new TextBox();
            this.btnTinh = new Button();
            this.btnLamLai = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 2 - Tính chu vi, diện tích hình chữ nhật";
            this.ClientSize = new Size(480, 310);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH CHỮ NHẬT";
            this.lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(20, 40, 80);
            this.lblTieuDe.Location = new Point(20, 20);
            this.lblTieuDe.Size = new Size(440, 30);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // lblChieuDai
            this.lblChieuDai.Text = "Chiều dài";
            this.lblChieuDai.Location = new Point(60, 70);
            this.lblChieuDai.Size = new Size(90, 25);

            // txtChieuDai
            this.txtChieuDai.Location = new Point(160, 67);
            this.txtChieuDai.Size = new Size(240, 29);

            // lblChieuRong
            this.lblChieuRong.Text = "Chiều rộng";
            this.lblChieuRong.Location = new Point(60, 112);
            this.lblChieuRong.Size = new Size(90, 25);

            // txtChieuRong
            this.txtChieuRong.Location = new Point(160, 109);
            this.txtChieuRong.Size = new Size(240, 29);

            // lblChuVi
            this.lblChuVi.Text = "Chu vi";
            this.lblChuVi.Location = new Point(60, 154);
            this.lblChuVi.Size = new Size(90, 25);

            // txtChuVi
            this.txtChuVi.Location = new Point(160, 151);
            this.txtChuVi.Size = new Size(240, 29);
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.BackColor = Color.FromArgb(220, 235, 252);

            // lblDienTich
            this.lblDienTich.Text = "Diện tích";
            this.lblDienTich.Location = new Point(60, 196);
            this.lblDienTich.Size = new Size(90, 25);

            // txtDienTich
            this.txtDienTich.Location = new Point(160, 193);
            this.txtDienTich.Size = new Size(240, 29);
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.BackColor = Color.FromArgb(220, 235, 252);

            // btnTinh
            this.btnTinh.Text = "Tính";
            this.btnTinh.Location = new Point(130, 245);
            this.btnTinh.Size = new Size(100, 35);
            this.btnTinh.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTinh.ForeColor = Color.White;
            this.btnTinh.FlatStyle = FlatStyle.Flat;
            this.btnTinh.Click += new EventHandler(this.BtnTinh_Click);

            // btnLamLai
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Location = new Point(260, 245);
            this.btnLamLai.Size = new Size(100, 35);
            this.btnLamLai.BackColor = Color.FromArgb(108, 117, 125);
            this.btnLamLai.ForeColor = Color.White;
            this.btnLamLai.FlatStyle = FlatStyle.Flat;
            this.btnLamLai.Click += new EventHandler(this.BtnLamLai_Click);

            // Add controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblChieuDai);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.lblChieuRong);
            this.Controls.Add(this.txtChieuRong);
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
            if (!double.TryParse(txtChieuDai.Text.Trim(), out double dai) || dai <= 0)
            {
                MessageBox.Show("Vui lòng nhập chiều dài > 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuDai.Focus();
                txtChieuDai.SelectAll();
                return;
            }

            if (!double.TryParse(txtChieuRong.Text.Trim(), out double rong) || rong <= 0)
            {
                MessageBox.Show("Vui lòng nhập chiều rộng > 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuRong.Focus();
                txtChieuRong.SelectAll();
                return;
            }

            double chuVi = 2 * (dai + rong);
            double dienTich = dai * rong;

            txtChuVi.Text = chuVi.ToString("G");
            txtDienTich.Text = dienTich.ToString("G");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtChieuDai.Clear();
            txtChieuRong.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtChieuDai.Focus();
        }
    }
}
