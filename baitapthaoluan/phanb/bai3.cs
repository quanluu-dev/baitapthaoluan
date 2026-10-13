using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai3 : Form
    {
        private Label lblTieuDe;
        private GroupBox grpHoaDon;
        private Label lblTenKhach;
        private Label lblDiaChi;
        private RadioButton radCaNhan;
        private RadioButton radDonViKhac;
        private Label lblSoLuongVe;
        private Label lblDonGia;
        private Label lblThanhTien;
        private Label lblVAT;
        private Label lblGiamGia;
        private Label lblTongCong;

        private TextBox txtTenKhach;
        private TextBox txtDiaChi;
        private TextBox txtSoLuongVe;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
        private TextBox txtVAT;
        private TextBox txtGiamGia;
        private TextBox txtTongCong;

        private PictureBox picMayBay;
        private GroupBox grpChucNang;
        private Button btnTinh;
        private Button btnTiep;
        private Button btnThoat;

        public bai3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.grpHoaDon = new GroupBox();
            this.lblTenKhach = new Label();
            this.txtTenKhach = new TextBox();
            this.lblDiaChi = new Label();
            this.txtDiaChi = new TextBox();
            this.radCaNhan = new RadioButton();
            this.radDonViKhac = new RadioButton();
            this.lblSoLuongVe = new Label();
            this.txtSoLuongVe = new TextBox();
            this.lblDonGia = new Label();
            this.txtDonGia = new TextBox();
            this.lblThanhTien = new Label();
            this.txtThanhTien = new TextBox();
            this.lblVAT = new Label();
            this.txtVAT = new TextBox();
            this.lblGiamGia = new Label();
            this.txtGiamGia = new TextBox();
            this.lblTongCong = new Label();
            this.txtTongCong = new TextBox();

            this.picMayBay = new PictureBox();
            this.grpChucNang = new GroupBox();
            this.btnTinh = new Button();
            this.btnTiep = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 3 - Chương trình bán vé máy bay";
            this.ClientSize = new Size(680, 470);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "CHƯƠNG TRÌNH BÁN VÉ MÁY BAY";
            this.lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(200, 30, 30);
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Size = new Size(640, 30);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // Group Hóa đơn
            this.grpHoaDon.Text = "Hóa đơn";
            this.grpHoaDon.Location = new Point(20, 50);
            this.grpHoaDon.Size = new Size(440, 400);

            // Tên khách hàng
            this.lblTenKhach.Text = "Tên khách hàng";
            this.lblTenKhach.Location = new Point(15, 30);
            this.lblTenKhach.Size = new Size(115, 25);
            this.txtTenKhach.Location = new Point(135, 27);
            this.txtTenKhach.Size = new Size(285, 29);

            // Địa chỉ
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.Location = new Point(15, 70);
            this.lblDiaChi.Size = new Size(115, 25);
            this.txtDiaChi.Location = new Point(135, 67);
            this.txtDiaChi.Size = new Size(285, 29);

            // Radio loại khách
            this.radCaNhan.Text = "Cá nhân";
            this.radCaNhan.Location = new Point(135, 105);
            this.radCaNhan.Size = new Size(100, 25);
            this.radCaNhan.Checked = true;

            this.radDonViKhac.Text = "Đơn vị khác";
            this.radDonViKhac.Location = new Point(265, 105);
            this.radDonViKhac.Size = new Size(120, 25);

            // Số lượng vé
            this.lblSoLuongVe.Text = "Số lượng vé";
            this.lblSoLuongVe.Location = new Point(15, 145);
            this.lblSoLuongVe.Size = new Size(115, 25);
            this.txtSoLuongVe.Location = new Point(135, 142);
            this.txtSoLuongVe.Size = new Size(285, 29);

            // Đơn giá
            this.lblDonGia.Text = "Đơn giá";
            this.lblDonGia.Location = new Point(15, 185);
            this.lblDonGia.Size = new Size(115, 25);
            this.txtDonGia.Location = new Point(135, 182);
            this.txtDonGia.Size = new Size(285, 29);

            // Thành tiền
            this.lblThanhTien.Text = "Thành tiền";
            this.lblThanhTien.Location = new Point(15, 225);
            this.lblThanhTien.Size = new Size(115, 25);
            this.txtThanhTien.Location = new Point(135, 222);
            this.txtThanhTien.Size = new Size(285, 29);
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.BackColor = Color.WhiteSmoke;

            // Thuế VAT
            this.lblVAT.Text = "Thuế VAT";
            this.lblVAT.Location = new Point(15, 265);
            this.lblVAT.Size = new Size(115, 25);
            this.txtVAT.Location = new Point(135, 262);
            this.txtVAT.Size = new Size(285, 29);
            this.txtVAT.ReadOnly = true;
            this.txtVAT.BackColor = Color.WhiteSmoke;

            // Giảm giá
            this.lblGiamGia.Text = "Giảm giá";
            this.lblGiamGia.Location = new Point(15, 305);
            this.lblGiamGia.Size = new Size(115, 25);
            this.txtGiamGia.Location = new Point(135, 302);
            this.txtGiamGia.Size = new Size(285, 29);
            this.txtGiamGia.ReadOnly = true;
            this.txtGiamGia.BackColor = Color.WhiteSmoke;

            // Tổng cộng
            this.lblTongCong.Text = "Tổng cộng";
            this.lblTongCong.Location = new Point(15, 345);
            this.lblTongCong.Size = new Size(115, 25);
            this.txtTongCong.Location = new Point(135, 342);
            this.txtTongCong.Size = new Size(285, 29);
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.BackColor = Color.FromArgb(220, 235, 252);
            this.txtTongCong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.txtTongCong.ForeColor = Color.DarkBlue;

            this.grpHoaDon.Controls.Add(this.lblTenKhach);
            this.grpHoaDon.Controls.Add(this.txtTenKhach);
            this.grpHoaDon.Controls.Add(this.lblDiaChi);
            this.grpHoaDon.Controls.Add(this.txtDiaChi);
            this.grpHoaDon.Controls.Add(this.radCaNhan);
            this.grpHoaDon.Controls.Add(this.radDonViKhac);
            this.grpHoaDon.Controls.Add(this.lblSoLuongVe);
            this.grpHoaDon.Controls.Add(this.txtSoLuongVe);
            this.grpHoaDon.Controls.Add(this.lblDonGia);
            this.grpHoaDon.Controls.Add(this.txtDonGia);
            this.grpHoaDon.Controls.Add(this.lblThanhTien);
            this.grpHoaDon.Controls.Add(this.txtThanhTien);
            this.grpHoaDon.Controls.Add(this.lblVAT);
            this.grpHoaDon.Controls.Add(this.txtVAT);
            this.grpHoaDon.Controls.Add(this.lblGiamGia);
            this.grpHoaDon.Controls.Add(this.txtGiamGia);
            this.grpHoaDon.Controls.Add(this.lblTongCong);
            this.grpHoaDon.Controls.Add(this.txtTongCong);

            // PictureBox máy bay
            this.picMayBay.Location = new Point(480, 58);
            this.picMayBay.Size = new Size(180, 150);
            this.picMayBay.Paint += new PaintEventHandler(this.PicMayBay_Paint);

            // GroupBox Chức năng
            this.grpChucNang.Text = "Chức năng";
            this.grpChucNang.Location = new Point(480, 220);
            this.grpChucNang.Size = new Size(180, 230);

            this.btnTinh.Text = "Tính";
            this.btnTinh.Location = new Point(35, 40);
            this.btnTinh.Size = new Size(110, 38);
            this.btnTinh.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTinh.ForeColor = Color.White;
            this.btnTinh.FlatStyle = FlatStyle.Flat;
            this.btnTinh.Click += new EventHandler(this.BtnTinh_Click);

            this.btnTiep.Text = "Tiếp";
            this.btnTiep.Location = new Point(35, 100);
            this.btnTiep.Size = new Size(110, 38);
            this.btnTiep.BackColor = Color.FromArgb(108, 117, 125);
            this.btnTiep.ForeColor = Color.White;
            this.btnTiep.FlatStyle = FlatStyle.Flat;
            this.btnTiep.Click += new EventHandler(this.BtnTiep_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(35, 160);
            this.btnThoat.Size = new Size(110, 38);
            this.btnThoat.BackColor = Color.FromArgb(205, 92, 92);
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.Click += new EventHandler(this.BtnThoat_Click);

            this.grpChucNang.Controls.Add(this.btnTinh);
            this.grpChucNang.Controls.Add(this.btnTiep);
            this.grpChucNang.Controls.Add(this.btnThoat);

            // Add Controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpHoaDon);
            this.Controls.Add(this.picMayBay);
            this.Controls.Add(this.grpChucNang);

            this.ResumeLayout(false);
        }

        private void PicMayBay_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new LinearGradientBrush(picMayBay.ClientRectangle, Color.FromArgb(135, 206, 250), Color.FromArgb(70, 130, 180), LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, picMayBay.ClientRectangle);
            }

            using (var planeBrush = new SolidBrush(Color.WhiteSmoke))
            using (var wingBrush = new SolidBrush(Color.FromArgb(220, 230, 240)))
            using (var borderPen = new Pen(Color.FromArgb(30, 60, 100), 2))
            {
                Point[] body = new Point[]
                {
                    new Point(30, 80),
                    new Point(120, 50),
                    new Point(155, 45),
                    new Point(145, 60),
                    new Point(60, 85),
                    new Point(30, 95)
                };
                g.FillPolygon(planeBrush, body);
                g.DrawPolygon(borderPen, body);

                Point[] wing = new Point[]
                {
                    new Point(70, 70),
                    new Point(100, 25),
                    new Point(120, 30),
                    new Point(95, 65)
                };
                g.FillPolygon(wingBrush, wing);
                g.DrawPolygon(borderPen, wing);

                Point[] tail = new Point[]
                {
                    new Point(35, 80),
                    new Point(20, 55),
                    new Point(35, 55),
                    new Point(50, 75)
                };
                g.FillPolygon(wingBrush, tail);
                g.DrawPolygon(borderPen, tail);
            }
        }

        private void BtnTinh_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtSoLuongVe.Text.Trim(), out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng vé phải là số nguyên > 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongVe.Focus();
                return;
            }

            if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số > 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            double thanhTien = sl * donGia;
            double vat = 0.10 * thanhTien;
            double tiLeGiam = radCaNhan.Checked ? 0.03 : 0.05;
            double giamGia = tiLeGiam * thanhTien;
            double tongTien = (thanhTien + vat) - giamGia;

            txtThanhTien.Text = thanhTien.ToString("#,##0") + " đ";
            txtVAT.Text = vat.ToString("#,##0") + " đ";
            txtGiamGia.Text = giamGia.ToString("#,##0") + " đ";
            txtTongCong.Text = tongTien.ToString("#,##0") + " đ";
        }

        private void BtnTiep_Click(object? sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtDiaChi.Clear();
            radCaNhan.Checked = true;
            txtSoLuongVe.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtVAT.Clear();
            txtGiamGia.Clear();
            txtTongCong.Clear();
            txtTenKhach.Focus();
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
