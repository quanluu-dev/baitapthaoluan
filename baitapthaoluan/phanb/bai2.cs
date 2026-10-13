using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai2 : Form
    {
        private Label lblTieuDe;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblGioiTinh;
        private Label lblDTB;
        private Label lblXepLoai;

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private RadioButton radNam;
        private RadioButton radNu;
        private GroupBox grpGioiTinh;
        private TextBox txtDTB;
        private TextBox txtXepLoai;

        private GroupBox grpMonHoc;
        private Label lblCSharp;
        private Label lblTruyenThong;
        private Label lblMaNguonMo;
        private Label lblQuanTriMang;
        private TextBox txtCSharp;
        private TextBox txtTruyenThong;
        private TextBox txtMaNguonMo;
        private TextBox txtQuanTriMang;

        private Button btnTinhDiem;
        private Button btnTiepTuc;
        private Button btnThoat;

        public bai2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblMaSV = new Label();
            this.lblHoTen = new Label();
            this.lblGioiTinh = new Label();
            this.lblDTB = new Label();
            this.lblXepLoai = new Label();

            this.txtMaSV = new TextBox();
            this.txtHoTen = new TextBox();
            this.grpGioiTinh = new GroupBox();
            this.radNam = new RadioButton();
            this.radNu = new RadioButton();
            this.txtDTB = new TextBox();
            this.txtXepLoai = new TextBox();

            this.grpMonHoc = new GroupBox();
            this.lblCSharp = new Label();
            this.lblTruyenThong = new Label();
            this.lblMaNguonMo = new Label();
            this.lblQuanTriMang = new Label();
            this.txtCSharp = new TextBox();
            this.txtTruyenThong = new TextBox();
            this.txtMaNguonMo = new TextBox();
            this.txtQuanTriMang = new TextBox();

            this.btnTinhDiem = new Button();
            this.btnTiepTuc = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 2 - Xếp loại học lực (nhiều môn)";
            this.ClientSize = new Size(680, 390);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 248, 240);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "XẾP LOẠI HỌC LỰC";
            this.lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(20, 60, 20);
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Size = new Size(640, 30);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // Thông tin sinh viên
            this.lblMaSV.Text = "Mã sinh viên";
            this.lblMaSV.Location = new Point(30, 65);
            this.lblMaSV.Size = new Size(110, 25);

            this.txtMaSV.Location = new Point(145, 62);
            this.txtMaSV.Size = new Size(165, 29);

            this.lblHoTen.Text = "Họ và tên";
            this.lblHoTen.Location = new Point(30, 105);
            this.lblHoTen.Size = new Size(110, 25);

            this.txtHoTen.Location = new Point(145, 102);
            this.txtHoTen.Size = new Size(165, 29);

            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.Location = new Point(30, 145);
            this.lblGioiTinh.Size = new Size(80, 25);

            this.grpGioiTinh.Location = new Point(145, 135);
            this.grpGioiTinh.Size = new Size(165, 45);
            this.radNam.Text = "Nam";
            this.radNam.Location = new Point(10, 15);
            this.radNam.Size = new Size(65, 25);
            this.radNam.Checked = true;
            this.radNu.Text = "Nữ";
            this.radNu.Location = new Point(85, 15);
            this.radNu.Size = new Size(65, 25);
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Controls.Add(this.radNu);

            this.lblDTB.Text = "Điểm trung bình";
            this.lblDTB.Location = new Point(30, 195);
            this.lblDTB.Size = new Size(110, 25);

            this.txtDTB.Location = new Point(145, 192);
            this.txtDTB.Size = new Size(165, 29);
            this.txtDTB.ReadOnly = true;
            this.txtDTB.BackColor = Color.WhiteSmoke;

            this.lblXepLoai.Text = "Xếp loại";
            this.lblXepLoai.Location = new Point(30, 235);
            this.lblXepLoai.Size = new Size(110, 25);

            this.txtXepLoai.Location = new Point(145, 232);
            this.txtXepLoai.Size = new Size(165, 29);
            this.txtXepLoai.ReadOnly = true;
            this.txtXepLoai.BackColor = Color.WhiteSmoke;
            this.txtXepLoai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);

            // GroupBox Môn học
            this.grpMonHoc.Text = "Danh sách các môn học";
            this.grpMonHoc.Location = new Point(335, 55);
            this.grpMonHoc.Size = new Size(315, 220);

            this.lblCSharp.Text = "Lập trình C#";
            this.lblCSharp.Location = new Point(15, 35);
            this.lblCSharp.Size = new Size(160, 25);

            this.txtCSharp.Location = new Point(185, 32);
            this.txtCSharp.Size = new Size(115, 29);

            this.lblTruyenThong.Text = "Lập trình truyền thông";
            this.lblTruyenThong.Location = new Point(15, 75);
            this.lblTruyenThong.Size = new Size(160, 25);

            this.txtTruyenThong.Location = new Point(185, 72);
            this.txtTruyenThong.Size = new Size(115, 29);

            this.lblMaNguonMo.Text = "Mã nguồn mở";
            this.lblMaNguonMo.Location = new Point(15, 115);
            this.lblMaNguonMo.Size = new Size(160, 25);

            this.txtMaNguonMo.Location = new Point(185, 112);
            this.txtMaNguonMo.Size = new Size(115, 29);

            this.lblQuanTriMang.Text = "Quản trị mạng";
            this.lblQuanTriMang.Location = new Point(15, 155);
            this.lblQuanTriMang.Size = new Size(160, 25);

            this.txtQuanTriMang.Location = new Point(185, 152);
            this.txtQuanTriMang.Size = new Size(115, 29);

            this.grpMonHoc.Controls.Add(this.lblCSharp);
            this.grpMonHoc.Controls.Add(this.txtCSharp);
            this.grpMonHoc.Controls.Add(this.lblTruyenThong);
            this.grpMonHoc.Controls.Add(this.txtTruyenThong);
            this.grpMonHoc.Controls.Add(this.lblMaNguonMo);
            this.grpMonHoc.Controls.Add(this.txtMaNguonMo);
            this.grpMonHoc.Controls.Add(this.lblQuanTriMang);
            this.grpMonHoc.Controls.Add(this.txtQuanTriMang);

            // Buttons
            this.btnTinhDiem.Text = "Tính điểm";
            this.btnTinhDiem.Location = new Point(155, 310);
            this.btnTinhDiem.Size = new Size(110, 38);
            this.btnTinhDiem.BackColor = Color.FromArgb(46, 139, 87);
            this.btnTinhDiem.ForeColor = Color.White;
            this.btnTinhDiem.FlatStyle = FlatStyle.Flat;
            this.btnTinhDiem.Click += new EventHandler(this.BtnTinhDiem_Click);

            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.Location = new Point(290, 310);
            this.btnTiepTuc.Size = new Size(110, 38);
            this.btnTiepTuc.BackColor = Color.FromArgb(70, 130, 180);
            this.btnTiepTuc.ForeColor = Color.White;
            this.btnTiepTuc.FlatStyle = FlatStyle.Flat;
            this.btnTiepTuc.Click += new EventHandler(this.BtnTiepTuc_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(425, 310);
            this.btnThoat.Size = new Size(110, 38);
            this.btnThoat.BackColor = Color.FromArgb(205, 92, 92);
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.Click += new EventHandler(this.BtnThoat_Click);

            // Add Controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.grpMonHoc);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnTinhDiem_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtCSharp.Text.Trim(), out double csharp) || csharp < 0 || csharp > 10)
            {
                MessageBox.Show("Điểm Lập trình C# phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCSharp.Focus();
                return;
            }

            if (!double.TryParse(txtTruyenThong.Text.Trim(), out double truyenThong) || truyenThong < 0 || truyenThong > 10)
            {
                MessageBox.Show("Điểm Lập trình truyền thông phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTruyenThong.Focus();
                return;
            }

            if (!double.TryParse(txtMaNguonMo.Text.Trim(), out double maNguonMo) || maNguonMo < 0 || maNguonMo > 10)
            {
                MessageBox.Show("Điểm Mã nguồn mở phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNguonMo.Focus();
                return;
            }

            if (!double.TryParse(txtQuanTriMang.Text.Trim(), out double quanTriMang) || quanTriMang < 0 || quanTriMang > 10)
            {
                MessageBox.Show("Điểm Quản trị mạng phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuanTriMang.Focus();
                return;
            }

            double dtb = (csharp + truyenThong + maNguonMo + quanTriMang) / 4.0;
            txtDTB.Text = dtb.ToString("F2");

            string xepLoai;
            if (dtb >= 8.0)
                xepLoai = "Giỏi";
            else if (dtb >= 7.0)
                xepLoai = "Khá";
            else if (dtb >= 5.0)
                xepLoai = "Trung bình";
            else
                xepLoai = "Yếu";

            txtXepLoai.Text = xepLoai;
        }

        private void BtnTiepTuc_Click(object? sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            radNam.Checked = true;
            txtCSharp.Clear();
            txtTruyenThong.Clear();
            txtMaNguonMo.Clear();
            txtQuanTriMang.Clear();
            txtDTB.Clear();
            txtXepLoai.Clear();
            txtMaSV.Focus();
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
