using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab02
{
    public partial class bai6 : Form
    {

        private string connectionString = "Data Source=quanlyanuong.db;Version=3;";
        private List<MonAnModel> danhSachMonAn = new List<MonAnModel>();
        private Random random = new Random();

        public bai6()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;

            // Đổi giao diện ListView thành dạng danh sách dọc cho đẹp mắt
            listView1.View = View.List;
        }


        public class MonAnModel
        {
            public int IDMA { get; set; }
            public string TenMonAn { get; set; } = string.Empty;
            public string HinhAnh { get; set; } = string.Empty;
            public string HoVaTenNguoiDung { get; set; } = string.Empty;
        }

        private void btnLoadSQLite_Click(object sender, EventArgs e)
        {
            danhSachMonAn.Clear();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen 
                                     FROM MonAn m 
                                     LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MonAnModel item = new MonAnModel()
                                {
                                    IDMA = Convert.ToInt32(reader["IDMA"]),
                                    TenMonAn = reader["TenMonAn"].ToString(),
                                    HinhAnh = reader["HinhAnh"] != DBNull.Value ? reader["HinhAnh"].ToString() : "",
                                    HoVaTenNguoiDung = reader["HoVaTen"] != DBNull.Value ? reader["HoVaTen"].ToString() : "Ẩn danh"
                                };
                                danhSachMonAn.Add(item);
                            }
                        }
                    }
                }

                listView1.Items.Clear();
                foreach (var mon in danhSachMonAn)
                {
                    listView1.Items.Add(mon.TenMonAn);
                }

                MessageBox.Show($"Đã tải thành công {danhSachMonAn.Count} món ăn từ SQLite!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn SQLite: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandommonan_Click(object sender, EventArgs e)
        {
            if (danhSachMonAn == null || danhSachMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống! Vui lòng bấm 'Tải dữ liệu SQLite' trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = random.Next(danhSachMonAn.Count);
            listView1.SelectedIndices.Clear();
            listView1.SelectedIndices.Add(index);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (danhSachMonAn == null || danhSachMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống! Vui lòng bấm 'Tải dữ liệu SQLite' trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = random.Next(danhSachMonAn.Count);
            listView1.SelectedItems.Clear();
            if (index < listView1.Items.Count)
            {
                listView1.Items[index].Selected = true;
                listView1.Items[index].Focused = true;
                listView1.EnsureVisible(index);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            int index = listView1.SelectedItems[0].Index;
            if (index >= 0 && index < danhSachMonAn.Count)
            {
                MonAnModel selectedMon = danhSachMonAn[index];

                labelTenMon.Text = $"Món: {selectedMon.TenMonAn}\nNgười đóng góp: {selectedMon.HoVaTenNguoiDung}";

                try
                {
                    string anhPath = selectedMon.HinhAnh.Trim();

                    if (!string.IsNullOrEmpty(anhPath))
                    {
                        string fullPath = Path.Combine(Application.StartupPath, anhPath);
                        if (!File.Exists(fullPath))
                        {
                            fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, anhPath);
                        }

                        if (!File.Exists(fullPath))
                        {
                            fullPath = Path.Combine(Directory.GetCurrentDirectory(), anhPath);
                        }

                        if (!File.Exists(fullPath) && File.Exists(anhPath))
                        {
                            fullPath = Path.GetFullPath(anhPath);
                        }

                        if (File.Exists(fullPath))
                        {
                            if (pictureBox1.Image != null)
                            {
                                pictureBox1.Image.Dispose();
                                pictureBox1.Image = null;
                            }

                            using (var tempImg = new Bitmap(fullPath))
                            {
                                pictureBox1.Image = new Bitmap(tempImg);
                            }
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch
                {
                    pictureBox1.Image = null;
                }

            }
        }
    }
}
