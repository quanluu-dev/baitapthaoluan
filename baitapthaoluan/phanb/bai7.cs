using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai7 : Form
    {
        private Panel pnlHeader;
        private Label lblHeader;

        private GroupBox grpThongTinNhap;
        private Label lblMaNV;
        private ComboBox cboMaNV;
        private Label lblTenNV;
        private TextBox txtTenNV;
        private Label lblLuongCB;
        private TextBox txtLuongCB;
        private Label lblSoNgayCong;
        private TextBox txtSoNgayCong;
        private Label lblHeSoPhuCap;
        private TextBox txtHeSoPhuCap;

        private GroupBox grpKetQua;
        private Label lblPhuCapCV;
        private TextBox txtPhuCapCV;
        private Label lblThuongNgay;
        private TextBox txtThuongNgay;
        private Label lblLuongThoiGian;
        private TextBox txtLuongThoiGian;
        private Label lblTongCong;
        private TextBox txtTongCong;

        private Button btnTinhLuong;
        private Button btnLamLai;
        private Button btnThoat;

        public bai7()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblHeader = new Label();

            this.grpThongTinNhap = new GroupBox();
            this.lblMaNV = new Label();
            this.cboMaNV = new ComboBox();
            this.lblTenNV = new Label();
            this.txtTenNV = new TextBox();
            this.lblLuongCB = new Label();
            this.txtLuongCB = new TextBox();
            this.lblSoNgayCong = new Label();
            this.txtSoNgayCong = new TextBox();
            this.lblHeSoPhuCap = new Label();
            this.txtHeSoPhuCap = new TextBox();

            this.grpKetQua = new GroupBox();
            this.lblPhuCapCV = new Label();
            this.txtPhuCapCV = new TextBox();
            this.lblThuongNgay = new Label();
            this.txtThuongNgay = new TextBox();
            this.lblLuongThoiGian = new Label();
            this.txtLuongThoiGian = new TextBox();
            this.lblTongCong = new Label();
            this.txtTongCong = new TextBox();

            this.btnTinhLuong = new Button();
            this.btnLamLai = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 7 - Tính lương nhân viên";
            this.ClientSize = new Size(680, 430);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // pnlHeader
            this.pnlHeader.BackColor = Color.FromArgb(13, 71, 161);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 50;

            this.lblHeader.Text = "TINH LUONG NHAN VIEN";
            this.lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Dock = DockStyle.Fill;
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            this.pnlHeader.Controls.Add(this.lblHeader);

            // GroupBox THÔNG TIN NHẬP
            this.grpThongTinNhap.Text = "THONG TIN NHAP";
            this.grpThongTinNhap.Location = new Point(25, 65);
            this.grpThongTinNhap.Size = new Size(300, 290);
            this.grpThongTinNhap.ForeColor = Color.FromArgb(13, 71, 161);
            this.grpThongTinNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);

            int startY = 25;
            int gapY = 50;

            this.lblMaNV.Text = "Ma nhan vien:";
            this.lblMaNV.Location = new Point(15, startY);
            this.lblMaNV.Size = new Size(130, 20);
            this.lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblMaNV.ForeColor = Color.Black;

            this.cboMaNV.Location = new Point(15, startY + 20);
            this.cboMaNV.Size = new Size(265, 28);
            this.cboMaNV.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.cboMaNV.ForeColor = Color.Black;
            this.cboMaNV.Items.AddRange(new object[] { "A001", "B002", "C003" });
            this.cboMaNV.SelectedIndex = 0;
            this.cboMaNV.SelectedIndexChanged += new EventHandler(this.CboMaNV_SelectedIndexChanged);

            this.lblTenNV.Text = "Ten nhan vien:";
            this.lblTenNV.Location = new Point(15, startY + gapY);
            this.lblTenNV.Size = new Size(130, 20);
            this.lblTenNV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblTenNV.ForeColor = Color.Black;

            this.txtTenNV.Location = new Point(15, startY + gapY + 20);
            this.txtTenNV.Size = new Size(265, 29);
            this.txtTenNV.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtTenNV.ForeColor = Color.Black;
            this.txtTenNV.Text = "Giang Thanh Tron";

            this.lblLuongCB.Text = "Luong co ban:";
            this.lblLuongCB.Location = new Point(15, startY + gapY * 2);
            this.lblLuongCB.Size = new Size(130, 20);
            this.lblLuongCB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblLuongCB.ForeColor = Color.Black;

            this.txtLuongCB.Location = new Point(15, startY + gapY * 2 + 20);
            this.txtLuongCB.Size = new Size(265, 29);
            this.txtLuongCB.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtLuongCB.ForeColor = Color.Black;
            this.txtLuongCB.Text = "500,000";

            this.lblSoNgayCong.Text = "So ngay cong:";
            this.lblSoNgayCong.Location = new Point(15, startY + gapY * 3);
            this.lblSoNgayCong.Size = new Size(130, 20);
            this.lblSoNgayCong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblSoNgayCong.ForeColor = Color.Black;

            this.txtSoNgayCong.Location = new Point(15, startY + gapY * 3 + 20);
            this.txtSoNgayCong.Size = new Size(265, 29);
            this.txtSoNgayCong.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtSoNgayCong.ForeColor = Color.Black;
            this.txtSoNgayCong.Text = "25";

            this.lblHeSoPhuCap.Text = "He so phu cap:";
            this.lblHeSoPhuCap.Location = new Point(15, startY + gapY * 4);
            this.lblHeSoPhuCap.Size = new Size(130, 20);
            this.lblHeSoPhuCap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblHeSoPhuCap.ForeColor = Color.Black;

            this.txtHeSoPhuCap.Location = new Point(15, startY + gapY * 4 + 20);
            this.txtHeSoPhuCap.Size = new Size(265, 29);
            this.txtHeSoPhuCap.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtHeSoPhuCap.ForeColor = Color.Black;
            this.txtHeSoPhuCap.Text = "1.5";

            this.grpThongTinNhap.Controls.Add(this.lblMaNV);
            this.grpThongTinNhap.Controls.Add(this.cboMaNV);
            this.grpThongTinNhap.Controls.Add(this.lblTenNV);
            this.grpThongTinNhap.Controls.Add(this.txtTenNV);
            this.grpThongTinNhap.Controls.Add(this.lblLuongCB);
            this.grpThongTinNhap.Controls.Add(this.txtLuongCB);
            this.grpThongTinNhap.Controls.Add(this.lblSoNgayCong);
            this.grpThongTinNhap.Controls.Add(this.txtSoNgayCong);
            this.grpThongTinNhap.Controls.Add(this.lblHeSoPhuCap);
            this.grpThongTinNhap.Controls.Add(this.txtHeSoPhuCap);

            // GroupBox KẾT QUẢ TÍNH TOÁN
            this.grpKetQua.Text = "KET QUA TINH TOAN";
            this.grpKetQua.Location = new Point(345, 65);
            this.grpKetQua.Size = new Size(305, 290);
            this.grpKetQua.ForeColor = Color.FromArgb(46, 125, 50);
            this.grpKetQua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);

            this.lblPhuCapCV.Text = "Phu cap chuc vu:";
            this.lblPhuCapCV.Location = new Point(15, startY);
            this.lblPhuCapCV.Size = new Size(140, 20);
            this.lblPhuCapCV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblPhuCapCV.ForeColor = Color.Black;

            this.txtPhuCapCV.Location = new Point(15, startY + 20);
            this.txtPhuCapCV.Size = new Size(270, 29);
            this.txtPhuCapCV.ReadOnly = true;
            this.txtPhuCapCV.BackColor = Color.FromArgb(235, 245, 235);
            this.txtPhuCapCV.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtPhuCapCV.ForeColor = Color.Black;

            this.lblThuongNgay.Text = "Thuong ngay:";
            this.lblThuongNgay.Location = new Point(15, startY + gapY);
            this.lblThuongNgay.Size = new Size(140, 20);
            this.lblThuongNgay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblThuongNgay.ForeColor = Color.Black;

            this.txtThuongNgay.Location = new Point(15, startY + gapY + 20);
            this.txtThuongNgay.Size = new Size(270, 29);
            this.txtThuongNgay.ReadOnly = true;
            this.txtThuongNgay.BackColor = Color.FromArgb(235, 245, 235);
            this.txtThuongNgay.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtThuongNgay.ForeColor = Color.Black;

            this.lblLuongThoiGian.Text = "Luong thoi gian:";
            this.lblLuongThoiGian.Location = new Point(15, startY + gapY * 2);
            this.lblLuongThoiGian.Size = new Size(140, 20);
            this.lblLuongThoiGian.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblLuongThoiGian.ForeColor = Color.Black;

            this.txtLuongThoiGian.Location = new Point(15, startY + gapY * 2 + 20);
            this.txtLuongThoiGian.Size = new Size(270, 29);
            this.txtLuongThoiGian.ReadOnly = true;
            this.txtLuongThoiGian.BackColor = Color.FromArgb(235, 245, 235);
            this.txtLuongThoiGian.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtLuongThoiGian.ForeColor = Color.Black;

            this.lblTongCong.Text = "TONG CONG:";
            this.lblTongCong.Location = new Point(15, startY + gapY * 3);
            this.lblTongCong.Size = new Size(140, 20);
            this.lblTongCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTongCong.ForeColor = Color.FromArgb(180, 40, 40);

            this.txtTongCong.Location = new Point(15, startY + gapY * 3 + 20);
            this.txtTongCong.Size = new Size(270, 29);
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.BackColor = Color.FromArgb(255, 240, 240);
            this.txtTongCong.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.txtTongCong.ForeColor = Color.FromArgb(180, 40, 40);

            this.grpKetQua.Controls.Add(this.lblPhuCapCV);
            this.grpKetQua.Controls.Add(this.txtPhuCapCV);
            this.grpKetQua.Controls.Add(this.lblThuongNgay);
            this.grpKetQua.Controls.Add(this.txtThuongNgay);
            this.grpKetQua.Controls.Add(this.lblLuongThoiGian);
            this.grpKetQua.Controls.Add(this.txtLuongThoiGian);
            this.grpKetQua.Controls.Add(this.lblTongCong);
            this.grpKetQua.Controls.Add(this.txtTongCong);

            // Buttons
            this.btnTinhLuong.Text = "TINH LUONG";
            this.btnTinhLuong.Location = new Point(70, 370);
            this.btnTinhLuong.Size = new Size(140, 40);
            this.btnTinhLuong.BackColor = Color.FromArgb(13, 71, 161);
            this.btnTinhLuong.ForeColor = Color.White;
            this.btnTinhLuong.FlatStyle = FlatStyle.Flat;
            this.btnTinhLuong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnTinhLuong.Click += new EventHandler(this.BtnTinhLuong_Click);

            this.btnLamLai.Text = "LAM LAI";
            this.btnLamLai.Location = new Point(270, 370);
            this.btnLamLai.Size = new Size(140, 40);
            this.btnLamLai.BackColor = Color.FromArgb(239, 108, 0);
            this.btnLamLai.ForeColor = Color.White;
            this.btnLamLai.FlatStyle = FlatStyle.Flat;
            this.btnLamLai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnLamLai.Click += new EventHandler(this.BtnLamLai_Click);

            this.btnThoat.Text = "THOAT";
            this.btnThoat.Location = new Point(470, 370);
            this.btnThoat.Size = new Size(140, 40);
            this.btnThoat.BackColor = Color.FromArgb(198, 40, 40);
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnThoat.Click += new EventHandler(this.BtnThoat_Click);

            // Add Controls
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpThongTinNhap);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
        }

        private void CboMaNV_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string ma = cboMaNV.SelectedItem?.ToString() ?? "";
            if (ma == "A001")
            {
                txtTenNV.Text = "Giang Thanh Tron";
                txtLuongCB.Text = "500,000";
            }
            else if (ma == "B002")
            {
                txtTenNV.Text = "Nguyen Van Binh";
                txtLuongCB.Text = "400,000";
            }
            else if (ma == "C003")
            {
                txtTenNV.Text = "Tran Thi Cam";
                txtLuongCB.Text = "350,000";
            }
        }

        private void BtnTinhLuong_Click(object? sender, EventArgs e)
        {
            string rawLuong = txtLuongCB.Text.Trim().Replace(",", "").Replace(".", "").Replace(" ", "");
            if (!double.TryParse(rawLuong, out double luongCB) || luongCB < 0)
            {
                MessageBox.Show("Lương cơ bản không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongCB.Focus();
                return;
            }

            if (!int.TryParse(txtSoNgayCong.Text.Trim(), out int soNgayCong) || soNgayCong < 0)
            {
                MessageBox.Show("Số ngày công không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNgayCong.Focus();
                return;
            }

            string maNV = cboMaNV.Text.Trim().ToUpper();
            char kyTuDau = maNV.Length > 0 ? maNV[0] : ' ';
            double phuCapCV = 0;
            switch (kyTuDau)
            {
                case 'A': phuCapCV = 500000; break;
                case 'B': phuCapCV = 300000; break;
                case 'C': phuCapCV = 200000; break;
                default: phuCapCV = 0; break;
            }

            double thuongNgay = soNgayCong * 50000;

            // Lương thời gian = Số ngày × Lương cơ bản. Nếu số ngày > 22 → số ngày dư được tính gấp đôi
            double luongThoiGian;
            if (soNgayCong > 22)
            {
                int ngayDu = soNgayCong - 22;
                luongThoiGian = (22 + ngayDu * 2.0) * luongCB;
            }
            else
            {
                luongThoiGian = soNgayCong * luongCB;
            }

            double tongCong = luongThoiGian + phuCapCV + thuongNgay;

            txtPhuCapCV.Text = phuCapCV.ToString("#,##0");
            txtThuongNgay.Text = thuongNgay.ToString("#,##0");
            txtLuongThoiGian.Text = luongThoiGian.ToString("#,##0");
            txtTongCong.Text = tongCong.ToString("#,##0");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            cboMaNV.SelectedIndex = 0;
            txtSoNgayCong.Text = "25";
            txtHeSoPhuCap.Text = "1.5";
            txtPhuCapCV.Clear();
            txtThuongNgay.Clear();
            txtLuongThoiGian.Clear();
            txtTongCong.Clear();
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
