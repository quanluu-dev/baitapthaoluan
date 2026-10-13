using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai3 : Form
    {
        private Label lblTieuDe;
        private Label lblHK1;
        private Label lblHK2;
        private Label lblDTB;
        private Label lblXepLoai;
        private TextBox txtHK1;
        private TextBox txtHK2;
        private TextBox txtDTB;
        private TextBox txtXepLoai;
        private Button btnDongY;
        private Button btnLamLai;

        public bai3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblHK1 = new Label();
            this.lblHK2 = new Label();
            this.lblDTB = new Label();
            this.lblXepLoai = new Label();
            this.txtHK1 = new TextBox();
            this.txtHK2 = new TextBox();
            this.txtDTB = new TextBox();
            this.txtXepLoai = new TextBox();
            this.btnDongY = new Button();
            this.btnLamLai = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 3 - Xếp loại học tập";
            this.ClientSize = new Size(480, 310);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "XẾP LOẠI HỌC TẬP";
            this.lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(20, 40, 80);
            this.lblTieuDe.Location = new Point(20, 20);
            this.lblTieuDe.Size = new Size(440, 30);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // lblHK1
            this.lblHK1.Text = "Điểm HKI";
            this.lblHK1.Location = new Point(60, 68);
            this.lblHK1.Size = new Size(90, 25);

            // txtHK1
            this.txtHK1.Location = new Point(160, 65);
            this.txtHK1.Size = new Size(240, 29);

            // lblHK2
            this.lblHK2.Text = "Điểm HKII";
            this.lblHK2.Location = new Point(60, 110);
            this.lblHK2.Size = new Size(90, 25);

            // txtHK2
            this.txtHK2.Location = new Point(160, 107);
            this.txtHK2.Size = new Size(240, 29);

            // lblDTB
            this.lblDTB.Text = "Điểm TB";
            this.lblDTB.Location = new Point(60, 152);
            this.lblDTB.Size = new Size(90, 25);

            // txtDTB
            this.txtDTB.Location = new Point(160, 149);
            this.txtDTB.Size = new Size(240, 29);
            this.txtDTB.ReadOnly = true;
            this.txtDTB.BackColor = Color.FromArgb(220, 235, 252);

            // lblXepLoai
            this.lblXepLoai.Text = "Xếp loại";
            this.lblXepLoai.Location = new Point(60, 194);
            this.lblXepLoai.Size = new Size(90, 25);

            // txtXepLoai
            this.txtXepLoai.Location = new Point(160, 191);
            this.txtXepLoai.Size = new Size(240, 29);
            this.txtXepLoai.ReadOnly = true;
            this.txtXepLoai.BackColor = Color.FromArgb(220, 235, 252);
            this.txtXepLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);

            // btnDongY
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Location = new Point(130, 245);
            this.btnDongY.Size = new Size(100, 35);
            this.btnDongY.BackColor = Color.FromArgb(41, 128, 185);
            this.btnDongY.ForeColor = Color.White;
            this.btnDongY.FlatStyle = FlatStyle.Flat;
            this.btnDongY.Click += new EventHandler(this.BtnDongY_Click);

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
            this.Controls.Add(this.lblHK1);
            this.Controls.Add(this.txtHK1);
            this.Controls.Add(this.lblHK2);
            this.Controls.Add(this.txtHK2);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnLamLai);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnDongY_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtHK1.Text.Trim(), out double hk1) || hk1 < 0 || hk1 > 10)
            {
                MessageBox.Show("Vui lòng nhập điểm HKI hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHK1.Focus();
                txtHK1.SelectAll();
                return;
            }

            if (!double.TryParse(txtHK2.Text.Trim(), out double hk2) || hk2 < 0 || hk2 > 10)
            {
                MessageBox.Show("Vui lòng nhập điểm HKII hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHK2.Focus();
                txtHK2.SelectAll();
                return;
            }

            double dtb = (hk1 + hk2 * 2.0) / 3.0;
            txtDTB.Text = dtb.ToString("F2");

            string xepLoai;
            if (dtb >= 8.0)
                xepLoai = "Giỏi";
            else if (dtb >= 6.5)
                xepLoai = "Khá";
            else if (dtb >= 5.0)
                xepLoai = "Trung bình";
            else
                xepLoai = "Yếu";

            txtXepLoai.Text = xepLoai;
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtHK1.Clear();
            txtHK2.Clear();
            txtDTB.Clear();
            txtXepLoai.Clear();
            txtHK1.Focus();
        }
    }
}
