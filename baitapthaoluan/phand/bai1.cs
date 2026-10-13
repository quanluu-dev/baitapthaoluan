using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitapthaoluan.phand
{
    public class bai1 : Form
    {
        private Label lblN;
        private TextBox txtN;
        private Button btnTaoMang;

        private Label lblX;
        private TextBox txtX;
        private Button btnTimX;

        private Button btnTimMaxMin;
        private Button btnDemDau;
        private Button btnDuongNhoNhatAmLonNhat;
        private Button btnSapXepGiam;
        private Button btnChayTatCa;
        private Button btnXoaConsole;

        private RichTextBox rtbConsole;

        private int[]? mangHienTai = null;

        public bai1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblN = new Label();
            this.txtN = new TextBox();
            this.btnTaoMang = new Button();

            this.lblX = new Label();
            this.txtX = new TextBox();
            this.btnTimX = new Button();

            this.btnTimMaxMin = new Button();
            this.btnDemDau = new Button();
            this.btnDuongNhoNhatAmLonNhat = new Button();
            this.btnSapXepGiam = new Button();
            this.btnChayTatCa = new Button();
            this.btnXoaConsole = new Button();

            this.rtbConsole = new RichTextBox();

            this.SuspendLayout();

            // Form
            this.Text = "Bài D1 - Mảng một chiều Console Simulator";
            this.ClientSize = new Size(740, 520);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 248, 252);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // Nhập N
            this.lblN.Text = "Nhập N (N < 20):";
            this.lblN.Location = new Point(20, 20);
            this.lblN.Size = new Size(115, 25);

            this.txtN.Location = new Point(140, 17);
            this.txtN.Size = new Size(70, 29);
            this.txtN.Text = "10";

            this.btnTaoMang.Text = "Phát sinh mảng [-100, 100]";
            this.btnTaoMang.Location = new Point(220, 15);
            this.btnTaoMang.Size = new Size(200, 32);
            this.btnTaoMang.BackColor = Color.FromArgb(41, 128, 185);
            this.btnTaoMang.ForeColor = Color.White;
            this.btnTaoMang.FlatStyle = FlatStyle.Flat;
            this.btnTaoMang.Click += new EventHandler(this.BtnTaoMang_Click);

            // Nhập x
            this.lblX.Text = "Nhập số x:";
            this.lblX.Location = new Point(440, 20);
            this.lblX.Size = new Size(80, 25);

            this.txtX.Location = new Point(525, 17);
            this.txtX.Size = new Size(70, 29);
            this.txtX.Text = "5";

            this.btnTimX.Text = "c. Kiểm tra x";
            this.btnTimX.Location = new Point(605, 15);
            this.btnTimX.Size = new Size(115, 32);
            this.btnTimX.BackColor = Color.FromArgb(52, 73, 94);
            this.btnTimX.ForeColor = Color.White;
            this.btnTimX.FlatStyle = FlatStyle.Flat;
            this.btnTimX.Click += new EventHandler(this.BtnTimX_Click);

            // Buttons thao tác theo từng yêu cầu đề bài
            int by = 60;
            this.btnTimMaxMin.Text = "a. Tìm Max, Min & vị trí";
            this.btnTimMaxMin.Location = new Point(20, by);
            this.btnTimMaxMin.Size = new Size(170, 32);
            this.btnTimMaxMin.Click += new EventHandler(this.BtnTimMaxMin_Click);

            this.btnDemDau.Text = "b. Đếm dương, âm, 0";
            this.btnDemDau.Location = new Point(200, by);
            this.btnDemDau.Size = new Size(160, 32);
            this.btnDemDau.Click += new EventHandler(this.BtnDemDau_Click);

            this.btnDuongNhoNhatAmLonNhat.Text = "d. Dương min, Âm max";
            this.btnDuongNhoNhatAmLonNhat.Location = new Point(370, by);
            this.btnDuongNhoNhatAmLonNhat.Size = new Size(170, 32);
            this.btnDuongNhoNhatAmLonNhat.Click += new EventHandler(this.BtnDuongNhoNhatAmLonNhat_Click);

            this.btnSapXepGiam.Text = "e. Sắp xếp giảm dần";
            this.btnSapXepGiam.Location = new Point(550, by);
            this.btnSapXepGiam.Size = new Size(170, 32);
            this.btnSapXepGiam.Click += new EventHandler(this.BtnSapXepGiam_Click);

            // Hàng nút tổng hợp
            int by2 = 100;
            this.btnChayTatCa.Text = "★ Chạy tất cả các câu (Full Report)";
            this.btnChayTatCa.Location = new Point(20, by2);
            this.btnChayTatCa.Size = new Size(250, 35);
            this.btnChayTatCa.BackColor = Color.FromArgb(46, 125, 50);
            this.btnChayTatCa.ForeColor = Color.White;
            this.btnChayTatCa.FlatStyle = FlatStyle.Flat;
            this.btnChayTatCa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnChayTatCa.Click += new EventHandler(this.BtnChayTatCa_Click);

            this.btnXoaConsole.Text = "Xóa màn hình Console";
            this.btnXoaConsole.Location = new Point(285, by2);
            this.btnXoaConsole.Size = new Size(170, 35);
            this.btnXoaConsole.BackColor = Color.FromArgb(108, 117, 125);
            this.btnXoaConsole.ForeColor = Color.White;
            this.btnXoaConsole.FlatStyle = FlatStyle.Flat;
            this.btnXoaConsole.Click += new EventHandler(this.BtnXoaConsole_Click);

            // RichTextBox Console simulator
            this.rtbConsole.Location = new Point(20, 145);
            this.rtbConsole.Size = new Size(700, 355);
            this.rtbConsole.BackColor = Color.FromArgb(12, 12, 12);
            this.rtbConsole.ForeColor = Color.FromArgb(0, 255, 65);
            this.rtbConsole.Font = new Font("Consolas", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.rtbConsole.ReadOnly = true;

            // Add Controls
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnTimX);

            this.Controls.Add(this.btnTimMaxMin);
            this.Controls.Add(this.btnDemDau);
            this.Controls.Add(this.btnDuongNhoNhatAmLonNhat);
            this.Controls.Add(this.btnSapXepGiam);

            this.Controls.Add(this.btnChayTatCa);
            this.Controls.Add(this.btnXoaConsole);
            this.Controls.Add(this.rtbConsole);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void WriteConsole(string text)
        {
            rtbConsole.AppendText(text + Environment.NewLine);
            rtbConsole.ScrollToCaret();
        }

        private bool KiemTraMang()
        {
            if (mangHienTai == null || mangHienTai.Length == 0)
            {
                MessageBox.Show("Vui lòng phát sinh mảng ngẫu nhiên trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ================= HÀM RIÊNG BIỆT CHO TỪNG YÊU CẦU =================
        public static int[] PhatSinhMang(int n)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-100, 101);
            }
            return arr;
        }

        // a. Tìm max, min và vị trí của chúng
        public static void TimMaxMin(int[] arr, out int max, out int posMax, out int min, out int posMin)
        {
            max = arr[0];
            min = arr[0];
            posMax = 0;
            posMin = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    posMax = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    posMin = i;
                }
            }
        }

        // b. Đếm số dương, số âm, số 0
        public static void DemSo(int[] arr, out int duong, out int am, out int so0)
        {
            duong = 0;
            am = 0;
            so0 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) duong++;
                else if (arr[i] < 0) am++;
                else so0++;
            }
        }

        // c. Kiểm tra số x có thuộc mảng hay không
        public static bool KiemTraX(int[] arr, int x, out System.Collections.Generic.List<int> viTri)
        {
            viTri = new System.Collections.Generic.List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    viTri.Add(i);
                }
            }
            return viTri.Count > 0;
        }

        // d. Tìm số dương nhỏ nhất, số âm lớn nhất
        public static void TimDuongMinAmMax(int[] arr, out int? duongMin, out int? amMax)
        {
            duongMin = null;
            amMax = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (duongMin == null || arr[i] < duongMin)
                        duongMin = arr[i];
                }
                else if (arr[i] < 0)
                {
                    if (amMax == null || arr[i] > amMax)
                        amMax = arr[i];
                }
            }
        }

        // e. Sắp xếp lại dãy số theo chiều giảm dần
        public static int[] SapXepGiamDan(int[] arr)
        {
            int[] ketQua = (int[])arr.Clone();
            Array.Sort(ketQua);
            Array.Reverse(ketQua);
            return ketQua;
        }

        // ================= XỬ LÝ SỰ KIỆN GIAO DIỆN =================
        private void BtnTaoMang_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text.Trim(), out int n) || n <= 0 || n >= 20)
            {
                MessageBox.Show("Vui lòng nhập N nguyên dương thỏa mãn N < 20!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                return;
            }

            mangHienTai = PhatSinhMang(n);

            WriteConsole($"=================== KHỞI TẠO MẢNG MỚI (N = {n}) ===================");
            WriteConsole("Mảng ban đầu: " + string.Join(", ", mangHienTai));
        }

        private void BtnTimMaxMin_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            TimMaxMin(mangHienTai!, out int max, out int posMax, out int min, out int posMin);

            WriteConsole(">>> a. TÌM MAX, MIN VÀ VỊ TRÍ:");
            WriteConsole($" - Giá trị lớn nhất (Max): {max} tại chỉ số [{posMax}]");
            WriteConsole($" - Giá trị nhỏ nhất (Min): {min} tại chỉ số [{posMin}]");
        }

        private void BtnDemDau_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            DemSo(mangHienTai!, out int duong, out int am, out int so0);

            WriteConsole(">>> b. ĐẾM SỐ DƯƠNG, SỐ ÂM, SỐ 0:");
            WriteConsole($" - Số phần tử dương (> 0): {duong}");
            WriteConsole($" - Số phần tử âm (< 0):    {am}");
            WriteConsole($" - Số phần tử bằng 0:       {so0}");
        }

        private void BtnTimX_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            if (!int.TryParse(txtX.Text.Trim(), out int x))
            {
                MessageBox.Show("Vui lòng nhập số nguyên x hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtX.Focus();
                return;
            }

            bool tonTai = KiemTraX(mangHienTai!, x, out var viTri);

            WriteConsole($">>> c. KIỂM TRA SỐ x = {x} CÓ THUỘC MẢNG HAY KHÔNG:");
            if (tonTai)
            {
                WriteConsole($" => Số {x} CÓ thuộc mảng tại các vị trí: [{string.Join(", ", viTri)}]");
            }
            else
            {
                WriteConsole($" => Số {x} KHÔNG thuộc mảng!");
            }
        }

        private void BtnDuongNhoNhatAmLonNhat_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            TimDuongMinAmMax(mangHienTai!, out int? duongMin, out int? amMax);

            WriteConsole(">>> d. TÌM SỐ DƯƠNG NHỎ NHẤT, SỐ ÂM LỚN NHẤT:");
            if (duongMin.HasValue)
                WriteConsole($" - Số dương nhỏ nhất: {duongMin.Value}");
            else
                WriteConsole(" - Không có số dương nào trong mảng.");

            if (amMax.HasValue)
                WriteConsole($" - Số âm lớn nhất:    {amMax.Value}");
            else
                WriteConsole(" - Không có số âm nào trong mảng.");
        }

        private void BtnSapXepGiam_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            int[] mangSapXep = SapXepGiamDan(mangHienTai!);

            WriteConsole(">>> e. SẮP XẾP LẠI DÃY SỐ THEO CHIỀU GIẢM DẦN:");
            WriteConsole("Dãy sau khi sắp xếp giảm dần: " + string.Join(", ", mangSapXep));
        }

        private void BtnChayTatCa_Click(object? sender, EventArgs e)
        {
            BtnTaoMang_Click(sender, e);
            if (mangHienTai == null) return;
            BtnTimMaxMin_Click(sender, e);
            BtnDemDau_Click(sender, e);
            BtnTimX_Click(sender, e);
            BtnDuongNhoNhatAmLonNhat_Click(sender, e);
            BtnSapXepGiam_Click(sender, e);
        }

        private void BtnXoaConsole_Click(object? sender, EventArgs e)
        {
            rtbConsole.Clear();
        }
    }
}
