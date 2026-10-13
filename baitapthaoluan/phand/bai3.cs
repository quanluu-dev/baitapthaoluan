using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitapthaoluan.phand
{
    public class bai3 : Form
    {
        private Label lblN;
        private TextBox txtN;

        private Label lblMang;
        private TextBox txtMang;

        private GroupBox grpMinMax;
        private RadioButton radMax;
        private RadioButton radMin;
        private TextBox txtKetQuaMinMax;

        private GroupBox grpSapXep;
        private RadioButton radTang;
        private RadioButton radGiam;
        private TextBox txtKetQuaSapXep;

        private Button btnTaoMang;
        private Button btnTimMinMax;
        private Button btnSapXep;
        private Button btnThoat;

        private int[] mangHienTai = Array.Empty<int>();

        public bai3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblN = new Label();
            this.txtN = new TextBox();

            this.lblMang = new Label();
            this.txtMang = new TextBox();

            this.grpMinMax = new GroupBox();
            this.radMax = new RadioButton();
            this.radMin = new RadioButton();
            this.txtKetQuaMinMax = new TextBox();

            this.grpSapXep = new GroupBox();
            this.radTang = new RadioButton();
            this.radGiam = new RadioButton();
            this.txtKetQuaSapXep = new TextBox();

            this.btnTaoMang = new Button();
            this.btnTimMinMax = new Button();
            this.btnSapXep = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài D3 - Dãy số (Tạo mảng - Min/Max - Sắp xếp)";
            this.ClientSize = new Size(620, 360);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 244, 250);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // Nhập N
            this.lblN.Text = "Nhập N";
            this.lblN.Location = new Point(25, 25);
            this.lblN.Size = new Size(110, 25);

            this.txtN.Location = new Point(145, 22);
            this.txtN.Size = new Size(270, 29);
            this.txtN.Text = "10";

            // Dãy số vừa nhập
            this.lblMang.Text = "Dãy số vừa nhập";
            this.lblMang.Location = new Point(25, 68);
            this.lblMang.Size = new Size(115, 25);

            this.txtMang.Location = new Point(145, 65);
            this.txtMang.Size = new Size(270, 29);
            this.txtMang.ReadOnly = true;
            this.txtMang.BackColor = Color.White;

            // GroupBox Tìm Min_Max
            this.grpMinMax.Text = "Tìm Min_Max";
            this.grpMinMax.Location = new Point(25, 110);
            this.grpMinMax.Size = new Size(130, 95);

            this.radMax.Text = "Max";
            this.radMax.Location = new Point(15, 25);
            this.radMax.Size = new Size(80, 25);
            this.radMax.Checked = true;

            this.radMin.Text = "Min";
            this.radMin.Location = new Point(15, 58);
            this.radMin.Size = new Size(80, 25);

            this.grpMinMax.Controls.Add(this.radMax);
            this.grpMinMax.Controls.Add(this.radMin);

            // TextBox kết quả Min/Max
            this.txtKetQuaMinMax.Location = new Point(165, 125);
            this.txtKetQuaMinMax.Size = new Size(250, 29);
            this.txtKetQuaMinMax.ReadOnly = true;
            this.txtKetQuaMinMax.BackColor = Color.White;

            // GroupBox Sắp xếp
            this.grpSapXep.Text = "Sắp xếp";
            this.grpSapXep.Location = new Point(25, 225);
            this.grpSapXep.Size = new Size(130, 95);

            this.radTang.Text = "Tăng";
            this.radTang.Location = new Point(15, 25);
            this.radTang.Size = new Size(80, 25);
            this.radTang.Checked = true;

            this.radGiam.Text = "Giảm";
            this.radGiam.Location = new Point(15, 58);
            this.radGiam.Size = new Size(80, 25);

            this.grpSapXep.Controls.Add(this.radTang);
            this.grpSapXep.Controls.Add(this.radGiam);

            // TextBox kết quả Sắp xếp
            this.txtKetQuaSapXep.Location = new Point(165, 240);
            this.txtKetQuaSapXep.Size = new Size(250, 29);
            this.txtKetQuaSapXep.ReadOnly = true;
            this.txtKetQuaSapXep.BackColor = Color.White;

            // 4 Buttons bên phải (khớp bố cục mẫu)
            int btnX = 445;
            int btnW = 145;
            int btnH = 34;

            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.Location = new Point(btnX, 63);
            this.btnTaoMang.Size = new Size(btnW, btnH);
            this.btnTaoMang.BackColor = Color.FromArgb(235, 240, 245);
            this.btnTaoMang.Click += new EventHandler(this.BtnTaoMang_Click);

            this.btnTimMinMax.Text = "Tìm Min - Max";
            this.btnTimMinMax.Location = new Point(btnX, 123);
            this.btnTimMinMax.Size = new Size(btnW, btnH);
            this.btnTimMinMax.BackColor = Color.FromArgb(235, 240, 245);
            this.btnTimMinMax.Click += new EventHandler(this.BtnTimMinMax_Click);

            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.Location = new Point(btnX, 238);
            this.btnSapXep.Size = new Size(btnW, btnH);
            this.btnSapXep.BackColor = Color.FromArgb(235, 240, 245);
            this.btnSapXep.Click += new EventHandler(this.BtnSapXep_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(btnX, 282);
            this.btnThoat.Size = new Size(btnW, btnH);
            this.btnThoat.BackColor = Color.FromArgb(235, 240, 245);
            this.btnThoat.Click += new EventHandler(this.BtnThoat_Click);

            // Add Controls
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblMang);
            this.Controls.Add(this.txtMang);
            this.Controls.Add(this.grpMinMax);
            this.Controls.Add(this.txtKetQuaMinMax);
            this.Controls.Add(this.grpSapXep);
            this.Controls.Add(this.txtKetQuaSapXep);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnTimMinMax);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnTaoMang_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text.Trim(), out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập N nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                return;
            }

            Random rand = new Random();
            mangHienTai = new int[n];
            for (int i = 0; i < n; i++)
            {
                mangHienTai[i] = rand.Next(1, 100);
            }

            txtMang.Text = string.Join(" ", mangHienTai);
            txtKetQuaMinMax.Clear();
            txtKetQuaSapXep.Clear();
        }

        private void BtnTimMinMax_Click(object? sender, EventArgs e)
        {
            if (mangHienTai.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Tạo mảng' trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int val = mangHienTai[0];
            if (radMax.Checked)
            {
                foreach (int x in mangHienTai)
                {
                    if (x > val) val = x;
                }
            }
            else
            {
                foreach (int x in mangHienTai)
                {
                    if (x < val) val = x;
                }
            }
            txtKetQuaMinMax.Text = val.ToString();
        }

        private void BtnSapXep_Click(object? sender, EventArgs e)
        {
            if (mangHienTai.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Tạo mảng' trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] sapXep = (int[])mangHienTai.Clone();
            Array.Sort(sapXep);
            if (radGiam.Checked)
            {
                Array.Reverse(sapXep);
            }

            txtKetQuaSapXep.Text = string.Join(" ", sapXep);
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
