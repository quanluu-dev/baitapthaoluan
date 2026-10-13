using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai1 : Form
    {
        private Label lblTieuDe;
        private Label lblMaKhach;
        private Label lblTenKhach;
        private Label lblChiSoMoi;
        private Label lblChiSoCu;
        private Label lblSoKw;
        private Label lblThanhTien;
        private Label lblVAT;
        private Label lblTongCong;

        private ComboBox cboMaKhach;
        private TextBox txtTenKhach;
        private RadioButton radCaNhan;
        private RadioButton radCoQuan;
        private GroupBox grpLoaiKhach;
        private TextBox txtChiSoMoi;
        private TextBox txtChiSoCu;
        private TextBox txtSoKw;
        private TextBox txtThanhTien;
        private TextBox txtVAT;
        private TextBox txtTongCong;

        private Button btnThucHien;
        private Button btnTiepTuc;
        private Button btnThoat;

        public bai1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblMaKhach = new Label();
            this.lblTenKhach = new Label();
            this.lblChiSoMoi = new Label();
            this.lblChiSoCu = new Label();
            this.lblSoKw = new Label();
            this.lblThanhTien = new Label();
            this.lblVAT = new Label();
            this.lblTongCong = new Label();

            this.cboMaKhach = new ComboBox();
            this.txtTenKhach = new TextBox();
            this.grpLoaiKhach = new GroupBox();
            this.radCaNhan = new RadioButton();
            this.radCoQuan = new RadioButton();
            this.txtChiSoMoi = new TextBox();
            this.txtChiSoCu = new TextBox();
            this.txtSoKw = new TextBox();
            this.txtThanhTien = new TextBox();
            this.txtVAT = new TextBox();
            this.txtTongCong = new TextBox();

            this.btnThucHien = new Button();
            this.btnTiepTuc = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 1 - Hóa đơn tiền điện (Cá nhân / Cơ quan)";
            this.ClientSize = new Size(620, 420);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 248, 240);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "BẢNG TÍNH TIỀN ĐIỆN";
            this.lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(180, 40, 40);
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Size = new Size(580, 35);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // Mã khách
            this.lblMaKhach.Text = "Mã khách";
            this.lblMaKhach.Location = new Point(40, 65);
            this.lblMaKhach.Size = new Size(110, 25);

            this.cboMaKhach.Location = new Point(155, 62);
            this.cboMaKhach.Size = new Size(130, 29);
            this.cboMaKhach.Items.AddRange(new object[] { "A01", "A02", "B01", "B02", "C01", "C02" });
            this.cboMaKhach.SelectedIndex = 0;
            this.cboMaKhach.SelectedIndexChanged += new EventHandler(this.CboMaKhach_SelectedIndexChanged);

            // Tên khách
            this.lblTenKhach.Text = "Tên khách";
            this.lblTenKhach.Location = new Point(310, 65);
            this.lblTenKhach.Size = new Size(90, 25);

            this.txtTenKhach.Location = new Point(405, 62);
            this.txtTenKhach.Size = new Size(175, 29);
            this.txtTenKhach.Text = "Nguyễn Văn An";

            // Loại khách
            this.grpLoaiKhach.Text = "Loại khách hàng";
            this.grpLoaiKhach.Location = new Point(40, 95);
            this.grpLoaiKhach.Size = new Size(540, 50);

            this.radCaNhan.Text = "Cá nhân";
            this.radCaNhan.Location = new Point(115, 18);
            this.radCaNhan.Size = new Size(120, 25);
            this.radCaNhan.Checked = true;

            this.radCoQuan.Text = "Cơ quan";
            this.radCoQuan.Location = new Point(365, 18);
            this.radCoQuan.Size = new Size(120, 25);

            this.grpLoaiKhach.Controls.Add(this.radCaNhan);
            this.grpLoaiKhach.Controls.Add(this.radCoQuan);

            // Chỉ số mới & Thành tiền
            this.lblChiSoMoi.Text = "Chỉ số mới";
            this.lblChiSoMoi.Location = new Point(40, 160);
            this.lblChiSoMoi.Size = new Size(110, 25);

            this.txtChiSoMoi.Location = new Point(155, 157);
            this.txtChiSoMoi.Size = new Size(130, 29);

            this.lblThanhTien.Text = "Thành tiền";
            this.lblThanhTien.Location = new Point(310, 160);
            this.lblThanhTien.Size = new Size(90, 25);

            this.txtThanhTien.Location = new Point(405, 157);
            this.txtThanhTien.Size = new Size(175, 29);
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.BackColor = Color.WhiteSmoke;

            // Chỉ số cũ & Thuế VAT
            this.lblChiSoCu.Text = "Chỉ số cũ";
            this.lblChiSoCu.Location = new Point(40, 205);
            this.lblChiSoCu.Size = new Size(110, 25);

            this.txtChiSoCu.Location = new Point(155, 202);
            this.txtChiSoCu.Size = new Size(130, 29);

            this.lblVAT.Text = "Thuế VAT";
            this.lblVAT.Location = new Point(310, 205);
            this.lblVAT.Size = new Size(90, 25);

            this.txtVAT.Location = new Point(405, 202);
            this.txtVAT.Size = new Size(175, 29);
            this.txtVAT.ReadOnly = true;
            this.txtVAT.BackColor = Color.WhiteSmoke;

            // Số Kw tiêu thụ & Tổng cộng
            this.lblSoKw.Text = "Số Kw tiêu thụ";
            this.lblSoKw.Location = new Point(40, 250);
            this.lblSoKw.Size = new Size(110, 25);

            this.txtSoKw.Location = new Point(155, 247);
            this.txtSoKw.Size = new Size(130, 29);
            this.txtSoKw.ReadOnly = true;
            this.txtSoKw.BackColor = Color.WhiteSmoke;

            this.lblTongCong.Text = "Tổng cộng";
            this.lblTongCong.Location = new Point(310, 250);
            this.lblTongCong.Size = new Size(90, 25);

            this.txtTongCong.Location = new Point(405, 247);
            this.txtTongCong.Size = new Size(175, 29);
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.BackColor = Color.FromArgb(220, 240, 255);
            this.txtTongCong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.txtTongCong.ForeColor = Color.DarkRed;

            // Buttons
            this.btnThucHien.Text = "Tính tiền";
            this.btnThucHien.Location = new Point(130, 320);
            this.btnThucHien.Size = new Size(110, 38);
            this.btnThucHien.BackColor = Color.FromArgb(46, 139, 87);
            this.btnThucHien.ForeColor = Color.White;
            this.btnThucHien.FlatStyle = FlatStyle.Flat;
            this.btnThucHien.Click += new EventHandler(this.BtnThucHien_Click);

            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.Location = new Point(265, 320);
            this.btnTiepTuc.Size = new Size(110, 38);
            this.btnTiepTuc.BackColor = Color.FromArgb(70, 130, 180);
            this.btnTiepTuc.ForeColor = Color.White;
            this.btnTiepTuc.FlatStyle = FlatStyle.Flat;
            this.btnTiepTuc.Click += new EventHandler(this.BtnTiepTuc_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(400, 320);
            this.btnThoat.Size = new Size(110, 38);
            this.btnThoat.BackColor = Color.FromArgb(205, 92, 92);
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.Click += new EventHandler(this.BtnThoat_Click);

            // Add Controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaKhach);
            this.Controls.Add(this.cboMaKhach);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.grpLoaiKhach);
            this.Controls.Add(this.lblChiSoMoi);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblChiSoCu);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.lblSoKw);
            this.Controls.Add(this.txtSoKw);
            this.Controls.Add(this.lblTongCong);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnThucHien_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtChiSoCu.Text.Trim(), out double cu) || cu < 0)
            {
                MessageBox.Show("Vui lòng nhập chỉ số cũ >= 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCu.Focus();
                return;
            }

            if (!double.TryParse(txtChiSoMoi.Text.Trim(), out double moi) || moi < cu)
            {
                MessageBox.Show("Chỉ số mới phải >= chỉ số cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoMoi.Focus();
                return;
            }

            double soKw = moi - cu;
            double donGia = radCaNhan.Checked ? 5000 : 6000;
            double thanhTien = soKw * donGia;
            double vat = thanhTien * 0.10;
            double tongCong = thanhTien + vat;

            txtSoKw.Text = soKw.ToString("N0");
            txtThanhTien.Text = thanhTien.ToString("#,##0") + " đ";
            txtVAT.Text = vat.ToString("#,##0") + " đ";
            txtTongCong.Text = tongCong.ToString("#,##0") + " đ";
        }

        private void BtnTiepTuc_Click(object? sender, EventArgs e)
        {
            txtChiSoCu.Clear();
            txtChiSoMoi.Clear();
            txtSoKw.Clear();
            txtThanhTien.Clear();
            txtVAT.Clear();
            txtTongCong.Clear();
            radCaNhan.Checked = true;
            cboMaKhach.Focus();
        }

        private void CboMaKhach_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboMaKhach.SelectedItem?.ToString() == "A01") txtTenKhach.Text = "Nguyễn Văn An";
            else if (cboMaKhach.SelectedItem?.ToString() == "A02") txtTenKhach.Text = "Trần Thị Bình";
            else if (cboMaKhach.SelectedItem?.ToString() == "B01") txtTenKhach.Text = "Công ty TNHH Ánh Dương";
            else if (cboMaKhach.SelectedItem?.ToString() == "B02") txtTenKhach.Text = "Công ty CP Sao Mai";
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
