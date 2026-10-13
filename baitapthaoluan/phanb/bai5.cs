using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai5 : Form
    {
        private Panel pnlHeader;
        private Label lblHeader;

        private Label lblNhapSo;
        private TextBox txtSoNguyen;
        private Button btnNhapSo;

        private ListBox lsbDaySo;
        private GroupBox grpChucNang;

        private Button btnTang2;
        private Button btnChonChanDau;
        private Button btnChonLeCuoi;
        private Button btnXoaChon;
        private Button btnXoaDau;
        private Button btnXoaCuoi;
        private Button btnXoaDaySo;
        private Button btnKetThuc;

        public bai5()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblHeader = new Label();

            this.lblNhapSo = new Label();
            this.txtSoNguyen = new TextBox();
            this.btnNhapSo = new Button();

            this.lsbDaySo = new ListBox();
            this.grpChucNang = new GroupBox();

            this.btnTang2 = new Button();
            this.btnChonChanDau = new Button();
            this.btnChonLeCuoi = new Button();
            this.btnXoaChon = new Button();
            this.btnXoaDau = new Button();
            this.btnXoaCuoi = new Button();
            this.btnXoaDaySo = new Button();
            this.btnKetThuc = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Bài 5 - Xử lý dãy số với ListBox";
            this.ClientSize = new Size(580, 470);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // pnlHeader
            this.pnlHeader.BackColor = Color.FromArgb(23, 162, 184);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 50;

            this.lblHeader.Text = "Ứng dụng xử lý dãy số";
            this.lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Dock = DockStyle.Fill;
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            this.pnlHeader.Controls.Add(this.lblHeader);

            // Nhập số nguyên
            this.lblNhapSo.Text = "Nhập số nguyên:";
            this.lblNhapSo.Location = new Point(25, 68);
            this.lblNhapSo.Size = new Size(130, 25);

            this.txtSoNguyen.Location = new Point(160, 65);
            this.txtSoNguyen.Size = new Size(140, 29);
            this.txtSoNguyen.KeyDown += new KeyEventHandler(this.TxtSoNguyen_KeyDown);

            this.btnNhapSo.Text = "Nhập số";
            this.btnNhapSo.Location = new Point(315, 63);
            this.btnNhapSo.Size = new Size(100, 32);
            this.btnNhapSo.BackColor = Color.FromArgb(41, 128, 185);
            this.btnNhapSo.ForeColor = Color.White;
            this.btnNhapSo.FlatStyle = FlatStyle.Flat;
            this.btnNhapSo.Click += new EventHandler(this.BtnNhapSo_Click);

            // ListBox lsbDaySo
            this.lsbDaySo.Location = new Point(25, 115);
            this.lsbDaySo.Size = new Size(240, 280);
            this.lsbDaySo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);

            // GroupBox Chức năng
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new Point(285, 105);
            this.grpChucNang.Size = new Size(265, 295);

            int btnY = 25;
            int btnHeight = 32;
            int btnSpacing = 37;

            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.Location = new Point(20, btnY);
            this.btnTang2.Size = new Size(225, btnHeight);
            this.btnTang2.Click += new EventHandler(this.BtnTang2_Click);

            this.btnChonChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonChanDau.Location = new Point(20, btnY + btnSpacing);
            this.btnChonChanDau.Size = new Size(225, btnHeight);
            this.btnChonChanDau.Click += new EventHandler(this.BtnChonChanDau_Click);

            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonLeCuoi.Location = new Point(20, btnY + btnSpacing * 2);
            this.btnChonLeCuoi.Size = new Size(225, btnHeight);
            this.btnChonLeCuoi.Click += new EventHandler(this.BtnChonLeCuoi_Click);

            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.Location = new Point(20, btnY + btnSpacing * 3);
            this.btnXoaChon.Size = new Size(225, btnHeight);
            this.btnXoaChon.Click += new EventHandler(this.BtnXoaChon_Click);

            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.Location = new Point(20, btnY + btnSpacing * 4);
            this.btnXoaDau.Size = new Size(225, btnHeight);
            this.btnXoaDau.Click += new EventHandler(this.BtnXoaDau_Click);

            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.Location = new Point(20, btnY + btnSpacing * 5);
            this.btnXoaCuoi.Size = new Size(225, btnHeight);
            this.btnXoaCuoi.Click += new EventHandler(this.BtnXoaCuoi_Click);

            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.Location = new Point(20, btnY + btnSpacing * 6);
            this.btnXoaDaySo.Size = new Size(225, btnHeight);
            this.btnXoaDaySo.Click += new EventHandler(this.BtnXoaDaySo_Click);

            this.grpChucNang.Controls.Add(this.btnTang2);
            this.grpChucNang.Controls.Add(this.btnChonChanDau);
            this.grpChucNang.Controls.Add(this.btnChonLeCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaChon);
            this.grpChucNang.Controls.Add(this.btnXoaDau);
            this.grpChucNang.Controls.Add(this.btnXoaCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaDaySo);

            // Nút Kết thúc ứng dụng
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.Location = new Point(25, 415);
            this.btnKetThuc.Size = new Size(240, 36);
            this.btnKetThuc.BackColor = Color.FromArgb(220, 53, 69);
            this.btnKetThuc.ForeColor = Color.White;
            this.btnKetThuc.FlatStyle = FlatStyle.Flat;
            this.btnKetThuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnKetThuc.Click += new EventHandler(this.BtnKetThuc_Click);

            // Add Controls
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.btnNhapSo);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnKetThuc);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnNhapSo_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtSoNguyen.Text.Trim(), out int val))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNguyen.Focus();
                txtSoNguyen.SelectAll();
                return;
            }

            lsbDaySo.Items.Add(val);
            txtSoNguyen.Clear();
            txtSoNguyen.Focus();
        }

        private void BtnTang2_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) return;

            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (int.TryParse(lsbDaySo.Items[i]?.ToString(), out int val))
                {
                    lsbDaySo.Items[i] = val + 2;
                }
            }
        }

        private void BtnChonChanDau_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (int.TryParse(lsbDaySo.Items[i]?.ToString(), out int val))
                {
                    if (val % 2 == 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        return;
                    }
                }
            }
            MessageBox.Show("Không tìm thấy số chẵn nào trong dãy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnChonLeCuoi_Click(object? sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (int.TryParse(lsbDaySo.Items[i]?.ToString(), out int val))
                {
                    if (val % 2 != 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        return;
                    }
                }
            }
            MessageBox.Show("Không tìm thấy số lẻ nào trong dãy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoaChon_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnXoaDau_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(0);
            }
        }

        private void BtnXoaCuoi_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
            }
        }

        private void BtnXoaDaySo_Click(object? sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void TxtSoNguyen_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnNhapSo_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnKetThuc_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
