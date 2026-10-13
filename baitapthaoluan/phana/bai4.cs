using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai4 : Form
    {
        private Label lblTieuDe;
        private Label lblChiSoDau;
        private Label lblChiSoCuoi;
        private Label lblTienPhaiDong;
        private TextBox txtChiSoDau;
        private TextBox txtChiSoCuoi;
        private TextBox txtTienPhaiDong;
        private Button btnDongY;
        private Button btnLamLai;

        public bai4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblChiSoDau = new Label();
            this.lblChiSoCuoi = new Label();
            this.lblTienPhaiDong = new Label();
            this.txtChiSoDau = new TextBox();
            this.txtChiSoCuoi = new TextBox();
            this.txtTienPhaiDong = new TextBox();
            this.btnDongY = new Button();
            this.btnLamLai = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 4 - Tính tiền điện theo bậc thang";
            this.ClientSize = new Size(480, 270);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "TÍNH TIỀN ĐIỆN";
            this.lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(20, 40, 80);
            this.lblTieuDe.Location = new Point(20, 20);
            this.lblTieuDe.Size = new Size(440, 30);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // lblChiSoDau
            this.lblChiSoDau.Text = "Chỉ số đầu";
            this.lblChiSoDau.Location = new Point(50, 70);
            this.lblChiSoDau.Size = new Size(130, 25);

            // txtChiSoDau
            this.txtChiSoDau.Location = new Point(190, 67);
            this.txtChiSoDau.Size = new Size(220, 29);

            // lblChiSoCuoi
            this.lblChiSoCuoi.Text = "Chỉ số cuối";
            this.lblChiSoCuoi.Location = new Point(50, 115);
            this.lblChiSoCuoi.Size = new Size(130, 25);

            // txtChiSoCuoi
            this.txtChiSoCuoi.Location = new Point(190, 112);
            this.txtChiSoCuoi.Size = new Size(220, 29);

            // lblTienPhaiDong
            this.lblTienPhaiDong.Text = "Số tiền phải đóng:";
            this.lblTienPhaiDong.Location = new Point(50, 160);
            this.lblTienPhaiDong.Size = new Size(135, 25);
            this.lblTienPhaiDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);

            // txtTienPhaiDong
            this.txtTienPhaiDong.Location = new Point(190, 157);
            this.txtTienPhaiDong.Size = new Size(220, 29);
            this.txtTienPhaiDong.ReadOnly = true;
            this.txtTienPhaiDong.BackColor = Color.FromArgb(220, 235, 252);
            this.txtTienPhaiDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.txtTienPhaiDong.ForeColor = Color.DarkBlue;

            // btnDongY
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Location = new Point(140, 210);
            this.btnDongY.Size = new Size(100, 35);
            this.btnDongY.BackColor = Color.FromArgb(41, 128, 185);
            this.btnDongY.ForeColor = Color.White;
            this.btnDongY.FlatStyle = FlatStyle.Flat;
            this.btnDongY.Click += new EventHandler(this.BtnDongY_Click);

            // btnLamLai
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Location = new Point(270, 210);
            this.btnLamLai.Size = new Size(100, 35);
            this.btnLamLai.BackColor = Color.FromArgb(108, 117, 125);
            this.btnLamLai.ForeColor = Color.White;
            this.btnLamLai.FlatStyle = FlatStyle.Flat;
            this.btnLamLai.Click += new EventHandler(this.BtnLamLai_Click);

            // Add controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblChiSoDau);
            this.Controls.Add(this.txtChiSoDau);
            this.Controls.Add(this.lblChiSoCuoi);
            this.Controls.Add(this.txtChiSoCuoi);
            this.Controls.Add(this.lblTienPhaiDong);
            this.Controls.Add(this.txtTienPhaiDong);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnLamLai);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnDongY_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtChiSoDau.Text.Trim(), out double dau) || dau < 0)
            {
                MessageBox.Show("Vui lòng nhập chỉ số đầu >= 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoDau.Focus();
                txtChiSoDau.SelectAll();
                return;
            }

            if (!double.TryParse(txtChiSoCuoi.Text.Trim(), out double cuoi) || cuoi < dau)
            {
                MessageBox.Show("Vui lòng nhập chỉ số cuối >= chỉ số đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCuoi.Focus();
                txtChiSoCuoi.SelectAll();
                return;
            }

            double kw = cuoi - dau;
            double tongTien = 0;

            if (kw <= 100)
            {
                tongTien = kw * 500;
            }
            else if (kw <= 250)
            {
                tongTien = (100 * 500) + ((kw - 100) * 600);
            }
            else if (kw <= 300)
            {
                tongTien = (100 * 500) + (150 * 600) + ((kw - 250) * 800);
            }
            else
            {
                tongTien = (100 * 500) + (150 * 600) + (50 * 800) + ((kw - 300) * 1000);
            }

            txtTienPhaiDong.Text = tongTien.ToString("#,##0.00");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtChiSoDau.Clear();
            txtChiSoCuoi.Clear();
            txtTienPhaiDong.Clear();
            txtChiSoDau.Focus();
        }
    }
}
