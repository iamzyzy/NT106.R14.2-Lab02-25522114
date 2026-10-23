using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace lab02
{
    public partial class bai5 : Form
    {
        private List<Phim> danhSachPhim = new List<Phim>();

        public bai5()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            string filePath = "input5.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file input5.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                danhSachPhim.Clear();
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i += 3)
                {
                    if (i + 2 < lines.Length)
                    {
                        Phim p = new Phim()
                        {
                            TenPhim = lines[i].Trim(),
                            GiaVeChuan = decimal.Parse(lines[i + 1].Trim()),
                            PhongChieu = lines[i + 2].Trim()
                        };
                        danhSachPhim.Add(p);
                    }
                }

                string display = $"Đã đọc thành công {danhSachPhim.Count} bộ phim từ input5.txt:\r\n\r\n";
                foreach (var p in danhSachPhim)
                {
                    display += $"- Phim: {p.TenPhim}, Giá vé: {p.GiaVeChuan:N0}đ, Phòng: {p.PhongChieu}\r\n";
                }
                richTextBox1.Text = display;

                MessageBox.Show("Đọc file input5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file input5.txt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnProcessAndExport_Click(object sender, EventArgs e)
        {
            if (danhSachPhim == null || danhSachPhim.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu phim! Vui lòng bấm 'Đọc File' trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;

                progressBar1.Value = 30;
                await System.Threading.Tasks.Task.Delay(200);

                var danhSachSapXep = danhSachPhim.OrderByDescending(p => p.DoanhThu).ToList();

                for (int i = 0; i < danhSachSapXep.Count; i++)
                {
                    danhSachSapXep[i].XepHang = i + 1;
                }

                progressBar1.Value = 70;
                await System.Threading.Tasks.Task.Delay(200);

                List<string> outputLines = new List<string>();
                string richTextDisplay = "BẢNG THỐNG KÊ DOANH THU PHÒNG VÉ\r\n\r\n";

                foreach (var p in danhSachSapXep)
                {
                    string line = $"Tên phim: {p.TenPhim}, Phòng: {p.PhongChieu}, Vé bán: {p.SoVeBanRa}, Vé tồn: {p.SoVeTon}, Tỉ lệ: {p.TileBanRa:F2}%, Doanh thu: {p.DoanhThu:N0}đ, Xếp hạng: {p.XepHang}";
                    outputLines.Add(line);
                    richTextDisplay += line + "\r\n\r\n";
                }

                File.WriteAllLines("output5.txt", outputLines);

                progressBar1.Value = 100;
                richTextBox1.Text = richTextDisplay;

                MessageBox.Show("Xuất file thống kê 'output5.txt' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Phim
    {
        public string TenPhim { get; set; } = string.Empty;
        public decimal GiaVeChuan { get; set; }
        public string PhongChieu { get; set; } = string.Empty;
        public int SoVeBanRa { get; set; } = 15;
        public int TongSoGhe { get; set; } = 30;
        public int SoVeTon => TongSoGhe - SoVeBanRa;
        public double TileBanRa => TongSoGhe > 0 ? (double)SoVeBanRa / TongSoGhe * 100 : 0;
        public decimal DoanhThu => SoVeBanRa * GiaVeChuan;
        public int XepHang { get; set; }
    }
}