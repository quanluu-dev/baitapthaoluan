using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai6 : Form
    {
        private Label lblTieuDe;
        private Label lblMaHV;
        private ComboBox cboMaHV;
        private Label lblGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private GroupBox grpGioiTinh;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgayDangKy;
        private DateTimePicker dtpNgayDangKy;

        private CheckBox chkTinHocA;
        private CheckBox chkTinHocB;
        private CheckBox chkTiengAnhA;
        private CheckBox chkTiengAnhB;

        private Label lblGiaTinHocA;
        private Label lblGiaTinHocB;
        private Label lblGiaTiengAnhA;
        private Label lblGiaTiengAnhB;

        private Label lblTongTien;
        private TextBox txtTongTien;

        private Button btnTinhTien;
        private Button btnCancel;
        private Button btnExit;

        public bai6()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblMaHV = new Label();
            this.cboMaHV = new ComboBox();
            this.lblGioiTinh = new Label();
            this.grpGioiTinh = new GroupBox();
            this.radNam = new RadioButton();
            this.radNu = new RadioButton();
            this.lblHoTen = new Label();
            this.txtHoTen = new TextBox();
            this.lblNgayDangKy = new Label();
            this.dtpNgayDangKy = new DateTimePicker();

            this.chkTinHocA = new CheckBox();
            this.chkTinHocB = new CheckBox();
            this.chkTiengAnhA = new CheckBox();
            this.chkTiengAnhB = new CheckBox();

            this.lblGiaTinHocA = new Label();
            this.lblGiaTinHocB = new Label();
            this.lblGiaTiengAnhA = new Label();
            this.lblGiaTiengAnhB = new Label();

            this.lblTongTien = new Label();
            this.txtTongTien = new TextBox();

            this.btnTinhTien = new Button();
            this.btnCancel = new Button();
            this.btnExit = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 6 - Tính tiền học trung tâm";
            this.ClientSize = new Size(580, 480);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(248, 248, 255);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // lblTieuDe
            this.lblTieuDe.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            this.lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(160, 32, 240);
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Size = new Size(540, 40);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // Mã Học Viên & Giới Tính
            this.lblMaHV.Text = "Mã Học Viên";
            this.lblMaHV.Location = new Point(40, 68);
            this.lblMaHV.Size = new Size(110, 25);

            this.cboMaHV.Location = new Point(160, 65);
            this.cboMaHV.Size = new Size(130, 29);
            this.cboMaHV.Items.AddRange(new object[] { "HV001", "HV002", "HV003", "HV004" });
            this.cboMaHV.SelectedIndex = 0;
            this.cboMaHV.SelectedIndexChanged += new EventHandler(this.CboMaHV_SelectedIndexChanged);

            this.lblGioiTinh.Text = "Giới Tính";
            this.lblGioiTinh.Location = new Point(315, 68);
            this.lblGioiTinh.Size = new Size(80, 25);

            this.grpGioiTinh.Location = new Point(395, 55);
            this.grpGioiTinh.Size = new Size(145, 45);

            this.radNam.Text = "Nam";
            this.radNam.Location = new Point(10, 15);
            this.radNam.Size = new Size(60, 25);
            this.radNam.Checked = true;

            this.radNu.Text = "Nữ";
            this.radNu.Location = new Point(75, 15);
            this.radNu.Size = new Size(60, 25);

            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Controls.Add(this.radNu);

            // Họ Tên
            this.lblHoTen.Text = "Họ Tên";
            this.lblHoTen.Location = new Point(40, 110);
            this.lblHoTen.Size = new Size(110, 25);

            this.txtHoTen.Location = new Point(160, 107);
            this.txtHoTen.Size = new Size(380, 29);
            this.txtHoTen.Text = "Nguyễn Văn Tuấn";

            // Ngày Đăng Ký
            this.lblNgayDangKy.Text = "Ngày Đăng Ký";
            this.lblNgayDangKy.Location = new Point(40, 152);
            this.lblNgayDangKy.Size = new Size(110, 25);

            this.dtpNgayDangKy.Location = new Point(160, 149);
            this.dtpNgayDangKy.Size = new Size(380, 29);
            this.dtpNgayDangKy.Format = DateTimePickerFormat.Long;

            // CheckBoxes Môn Học
            int courseY = 195;
            int stepY = 38;

            this.chkTinHocA.Text = "Tin học A";
            this.chkTinHocA.Location = new Point(120, courseY);
            this.chkTinHocA.Size = new Size(160, 25);

            this.lblGiaTinHocA.Text = "300.000 đồng";
            this.lblGiaTinHocA.Location = new Point(350, courseY);
            this.lblGiaTinHocA.Size = new Size(150, 25);
            this.lblGiaTinHocA.TextAlign = ContentAlignment.MiddleRight;

            this.chkTinHocB.Text = "Tin học B";
            this.chkTinHocB.Location = new Point(120, courseY + stepY);
            this.chkTinHocB.Size = new Size(160, 25);

            this.lblGiaTinHocB.Text = "500.000 đồng";
            this.lblGiaTinHocB.Location = new Point(350, courseY + stepY);
            this.lblGiaTinHocB.Size = new Size(150, 25);
            this.lblGiaTinHocB.TextAlign = ContentAlignment.MiddleRight;

            this.chkTiengAnhA.Text = "Tiếng Anh A";
            this.chkTiengAnhA.Location = new Point(120, courseY + stepY * 2);
            this.chkTiengAnhA.Size = new Size(160, 25);

            this.lblGiaTiengAnhA.Text = "400.000 đồng";
            this.lblGiaTiengAnhA.Location = new Point(350, courseY + stepY * 2);
            this.lblGiaTiengAnhA.Size = new Size(150, 25);
            this.lblGiaTiengAnhA.TextAlign = ContentAlignment.MiddleRight;

            this.chkTiengAnhB.Text = "Tiếng Anh B";
            this.chkTiengAnhB.Location = new Point(120, courseY + stepY * 3);
            this.chkTiengAnhB.Size = new Size(160, 25);

            this.lblGiaTiengAnhB.Text = "600.000 đồng";
            this.lblGiaTiengAnhB.Location = new Point(350, courseY + stepY * 3);
            this.lblGiaTiengAnhB.Size = new Size(150, 25);
            this.lblGiaTiengAnhB.TextAlign = ContentAlignment.MiddleRight;

            // Tổng Tiền
            this.lblTongTien.Text = "Tổng Tiền";
            this.lblTongTien.Location = new Point(120, courseY + stepY * 4 + 8);
            this.lblTongTien.Size = new Size(110, 25);
            this.lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);

            this.txtTongTien.Location = new Point(270, courseY + stepY * 4 + 5);
            this.txtTongTien.Size = new Size(230, 29);
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.BackColor = Color.FromArgb(230, 245, 255);
            this.txtTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.txtTongTien.ForeColor = Color.DarkBlue;

            // Buttons
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.Location = new Point(70, 420);
            this.btnTinhTien.Size = new Size(120, 38);
            this.btnTinhTien.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTinhTien.ForeColor = Color.White;
            this.btnTinhTien.FlatStyle = FlatStyle.Flat;
            this.btnTinhTien.Click += new EventHandler(this.BtnTinhTien_Click);

            this.btnCancel.Text = "✖ Cancel";
            this.btnCancel.Location = new Point(230, 420);
            this.btnCancel.Size = new Size(120, 38);
            this.btnCancel.BackColor = Color.FromArgb(220, 100, 100);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Click += new EventHandler(this.BtnCancel_Click);

            this.btnExit.Text = "Exit";
            this.btnExit.Location = new Point(390, 420);
            this.btnExit.Size = new Size(120, 38);
            this.btnExit.BackColor = Color.FromArgb(108, 117, 125);
            this.btnExit.ForeColor = Color.White;
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.Click += new EventHandler(this.BtnExit_Click);

            // Add Controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaHV);
            this.Controls.Add(this.cboMaHV);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgayDangKy);
            this.Controls.Add(this.dtpNgayDangKy);

            this.Controls.Add(this.chkTinHocA);
            this.Controls.Add(this.lblGiaTinHocA);
            this.Controls.Add(this.chkTinHocB);
            this.Controls.Add(this.lblGiaTinHocB);
            this.Controls.Add(this.chkTiengAnhA);
            this.Controls.Add(this.lblGiaTiengAnhA);
            this.Controls.Add(this.chkTiengAnhB);
            this.Controls.Add(this.lblGiaTiengAnhB);

            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTongTien);

            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnTinhTien_Click(object? sender, EventArgs e)
        {
            double tongTien = 0;
            if (chkTinHocA.Checked) tongTien += 300000;
            if (chkTinHocB.Checked) tongTien += 500000;
            if (chkTiengAnhA.Checked) tongTien += 400000;
            if (chkTiengAnhB.Checked) tongTien += 600000;

            txtTongTien.Text = tongTien.ToString("#,##0") + " đồng";
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            chkTinHocA.Checked = false;
            chkTinHocB.Checked = false;
            chkTiengAnhA.Checked = false;
            chkTiengAnhB.Checked = false;
            txtTongTien.Clear();
        }

        private void CboMaHV_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboMaHV.SelectedItem?.ToString() == "HV001") txtHoTen.Text = "Nguyễn Văn Tuấn";
            else if (cboMaHV.SelectedItem?.ToString() == "HV002") txtHoTen.Text = "Trần Thị Mai";
            else if (cboMaHV.SelectedItem?.ToString() == "HV003") txtHoTen.Text = "Lê Hoàng Nam";
            else if (cboMaHV.SelectedItem?.ToString() == "HV004") txtHoTen.Text = "Phạm Thị Hương";
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
