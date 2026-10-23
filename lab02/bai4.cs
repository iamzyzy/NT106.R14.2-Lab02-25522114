using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace lab02
{
    public partial class bai4 : Form
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();
        private List<SinhVien> danhSachDocTuFile = new List<SinhVien>();
        private int currentIndex = 0;

        public bai4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtInputName.Text.Trim();
                string mssvStr = txtInputID.Text.Trim();
                string phone = txtInputPhone.Text.Trim();
                string c1Str = txtInputCourse1.Text.Trim();
                string c2Str = txtInputCourse2.Text.Trim();
                string c3Str = txtInputCourse3.Text.Trim();

                if (string.IsNullOrEmpty(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(mssvStr, out int mssv) || mssvStr.Length != 8)
                {
                    MessageBox.Show("Mã số sinh viên phải là một số có đúng 8 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (phone.Length != 10 || !phone.StartsWith("0") || !long.TryParse(phone, out _))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(c1Str, out float c1) || c1 < 0 || c1 > 10 ||
                    !float.TryParse(c2Str, out float c2) || c2 < 0 || c2 > 10 ||
                    !float.TryParse(c3Str, out float c3) || c3 < 0 || c3 > 10)
                {
                    MessageBox.Show("Điểm các môn phải là số thực từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SinhVien sv = new SinhVien()
                {
                    HoTen = hoTen,
                    MSSV = mssv,
                    DienThoai = phone,
                    DiemMon1 = c1,
                    DiemMon2 = c2,
                    DiemMon3 = c3,
                    DiemTrungBinh = 0
                };

                danhSachSV.Add(sv);
                XoaFormNhap();
                MessageBox.Show("Đã thêm sinh viên vào danh sách tạm!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            if (danhSachSV == null || danhSachSV.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string filePath = "input4.txt";
                string jsonString = JsonSerializer.Serialize(danhSachSV, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);

                string display = "";
                foreach (var sv in danhSachSV)
                {
                    display += $"{sv.HoTen}\r\n{sv.MSSV}\r\n{sv.DienThoai}\r\n{sv.DiemMon1}\r\n{sv.DiemMon2}\r\n{sv.DiemMon3}\r\n\r\n";
                }
                richTextBox1.Text = display;

                MessageBox.Show("Ghi file input4.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            string inputPath = "input4.txt";
            string outputPath = "output4.txt";

            if (!File.Exists(inputPath))
            {
                MessageBox.Show("Không tìm thấy file input4.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string jsonString = File.ReadAllText(inputPath);
                danhSachDocTuFile = JsonSerializer.Deserialize<List<SinhVien>>(jsonString);

                if (danhSachDocTuFile != null && danhSachDocTuFile.Count > 0)
                {
                    List<string> outputLines = new List<string>();
                    foreach (var sv in danhSachDocTuFile)
                    {
                        sv.TinhDTB();
                        outputLines.Add($"Họ tên: {sv.HoTen} - MSSV: {sv.MSSV} - ĐT: {sv.DienThoai} - M1: {sv.DiemMon1} - M2: {sv.DiemMon2} - M3: {sv.DiemMon3} - ĐTB: {sv.DiemTrungBinh:F2}");
                    }

                    File.WriteAllLines(outputPath, outputLines);

                    currentIndex = 0;
                    HienThiSinhVienTheoTrang();

                    MessageBox.Show("Đọc file thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("File input4.txt trống!", "Cảnh báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message, "Lỗi");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (danhSachDocTuFile == null || danhSachDocTuFile.Count == 0)
            {
                MessageBox.Show("Bạn chưa đọc file!", "Cảnh báo");
                return;
            }

            if (currentIndex > 0)
            {
                currentIndex--;
                HienThiSinhVienTheoTrang();
            }
            else
            {
                MessageBox.Show("Đây là sinh viên đầu tiên!", "Thông báo");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (danhSachDocTuFile == null || danhSachDocTuFile.Count == 0)
            {
                MessageBox.Show("Bạn chưa đọc file!", "Cảnh báo");
                return;
            }

            if (currentIndex < danhSachDocTuFile.Count - 1)
            {
                currentIndex++;
                HienThiSinhVienTheoTrang();
            }
            else
            {
                MessageBox.Show("Đây là sinh viên cuối cùng!", "Thông báo");
            }
        }

        private void HienThiSinhVienTheoTrang()
        {
            if (danhSachDocTuFile == null || danhSachDocTuFile.Count == 0) return;

            SinhVien sv = danhSachDocTuFile[currentIndex];

            txtNameOutput.Text = sv.HoTen;
            txtIDOutput.Text = sv.MSSV.ToString();
            txtPhoneOutput.Text = sv.DienThoai;
            txtCourse1Output.Text = sv.DiemMon1.ToString();
            txtCourse2Output.Text = sv.DiemMon2.ToString();
            txtCourse3Output.Text = sv.DiemMon3.ToString();
            txtAverageOutput.Text = sv.DiemTrungBinh.ToString("F2");

            lblPageNumber.Text = $"{currentIndex + 1} / {danhSachDocTuFile.Count}";
        }

        private void XoaFormNhap()
        {
            txtInputName.Clear();
            txtInputID.Clear();
            txtInputPhone.Clear();
            txtInputCourse1.Clear();
            txtInputCourse2.Clear();
            txtInputCourse3.Clear();
        }
    }
    [Serializable]
    public class SinhVien
    {
        public string HoTen { get; set; } = string.Empty;
        public int MSSV { get; set; }
        public string DienThoai { get; set; } = string.Empty;
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTrungBinh { get; set; }

        public void TinhDTB()
        {
            DiemTrungBinh = (DiemMon1 + DiemMon2 + DiemMon3) / 3;
        }
    }
}