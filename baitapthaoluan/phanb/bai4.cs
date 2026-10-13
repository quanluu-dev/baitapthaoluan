using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai4 : Form
    {
        private GroupBox grpNhap;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;

        private GroupBox grpTuyChon;
        private RadioButton radUSCLN;
        private RadioButton radBSCNN;

        private Label lblKetQua;
        private TextBox txtKetQua;

        private Button btnTim;
        private Button btnThoat;

        public bai4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.grpNhap = new GroupBox();
            this.lblA = new Label();
            this.lblB = new Label();
            this.txtA = new TextBox();
            this.txtB = new TextBox();

            this.grpTuyChon = new GroupBox();
            this.radUSCLN = new RadioButton();
            this.radBSCNN = new RadioButton();

            this.lblKetQua = new Label();
            this.txtKetQua = new TextBox();

            this.btnTim = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 4 - Tìm USCLN và BSCNN của số nguyên a và b";
            this.ClientSize = new Size(540, 260);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 248, 255);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // Group Nhập dữ liệu
            this.grpNhap.Text = "Nhập dữ liệu:";
            this.grpNhap.Location = new Point(25, 20);
            this.grpNhap.Size = new Size(320, 115);
            this.grpNhap.BackColor = Color.FromArgb(220, 245, 230);

            this.lblA.Text = "Số nguyên a:";
            this.lblA.Location = new Point(15, 32);
            this.lblA.Size = new Size(110, 25);

            this.txtA.Location = new Point(130, 29);
            this.txtA.Size = new Size(165, 29);

            this.lblB.Text = "Số nguyên b:";
            this.lblB.Location = new Point(15, 72);
            this.lblB.Size = new Size(110, 25);

            this.txtB.Location = new Point(130, 69);
            this.txtB.Size = new Size(165, 29);

            this.grpNhap.Controls.Add(this.lblA);
            this.grpNhap.Controls.Add(this.txtA);
            this.grpNhap.Controls.Add(this.lblB);
            this.grpNhap.Controls.Add(this.txtB);

            // Group Tùy chọn
            this.grpTuyChon.Text = "Tùy chọn:";
            this.grpTuyChon.Location = new Point(365, 20);
            this.grpTuyChon.Size = new Size(150, 115);

            this.radUSCLN.Text = "USCLN";
            this.radUSCLN.Location = new Point(20, 32);
            this.radUSCLN.Size = new Size(110, 25);
            this.radUSCLN.Checked = true;

            this.radBSCNN.Text = "BSCNN";
            this.radBSCNN.Location = new Point(20, 72);
            this.radBSCNN.Size = new Size(110, 25);

            this.grpTuyChon.Controls.Add(this.radUSCLN);
            this.grpTuyChon.Controls.Add(this.radBSCNN);

            // Kết quả
            this.lblKetQua.Text = "Kết quả:";
            this.lblKetQua.Location = new Point(25, 155);
            this.lblKetQua.Size = new Size(80, 25);

            this.txtKetQua.Location = new Point(155, 152);
            this.txtKetQua.Size = new Size(190, 29);
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.BackColor = Color.FromArgb(235, 245, 255);
            this.txtKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);

            // Buttons
            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new Point(385, 150);
            this.btnTim.Size = new Size(110, 32);
            this.btnTim.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTim.ForeColor = Color.White;
            this.btnTim.FlatStyle = FlatStyle.Flat;
            this.btnTim.Click += new EventHandler(this.BtnTim_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(385, 195);
            this.btnThoat.Size = new Size(110, 32);
            this.btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.Click += new EventHandler(this.BtnThoat_Click);

            // Add Controls
            this.Controls.Add(this.grpNhap);
            this.Controls.Add(this.grpTuyChon);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private long TimUSCLN(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private long TimBSCNN(long a, long b)
        {
            if (a == 0 || b == 0) return 0;
            long uscln = TimUSCLN(a, b);
            return Math.Abs(a * b) / uscln;
        }

        private void BtnTim_Click(object? sender, EventArgs e)
        {
            if (!long.TryParse(txtA.Text.Trim(), out long a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên a hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }

            if (!long.TryParse(txtB.Text.Trim(), out long b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên b hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return;
            }

            if (radUSCLN.Checked)
            {
                long uscln = TimUSCLN(a, b);
                txtKetQua.Text = uscln.ToString();
            }
            else
            {
                if (a == 0 && b == 0)
                {
                    MessageBox.Show("Không có BSCNN cho hai số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                long bscnn = TimBSCNN(a, b);
                txtKetQua.Text = bscnn.ToString();
            }
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
