using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab02
{
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
            treeView1.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeExpand);
            treeView1.AfterSelect += new TreeViewEventHandler(treeView1_AfterSelect);

            LoadDriveD();
        }
        private void LoadDriveD()
        {
            treeView1.Nodes.Clear();
            string drivePath = @"D:\";

            if (Directory.Exists(drivePath))
            {
                TreeNode rootNode = new TreeNode("New Volume (D:\\)") { Tag = drivePath };

                rootNode.Nodes.Add("Loading...");
                treeView1.Nodes.Add(rootNode);
            }
            else
            {
                MessageBox.Show("Ổ đĩa D:\\ không tồn tại trên máy tính này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDirectory(string dirPath, TreeNode node)
        {
            try
            {
                foreach (string subDir in Directory.GetDirectories(dirPath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(subDir);
                    TreeNode subNode = new TreeNode(dirInfo.Name) { Tag = subDir };
                    subNode.Nodes.Add("Loading...");
                    node.Nodes.Add(subNode);
                }

                foreach (string file in Directory.GetFiles(dirPath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    TreeNode fileNode = new TreeNode(fileInfo.Name) { Tag = file };
                    node.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "Loading...")
            {
                node.Nodes.Clear();
                string dirPath = node.Tag.ToString();
                LoadDirectory(dirPath, node);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null)
            {
                string path = e.Node.Tag.ToString();

                if (File.Exists(path))
                {
                    try
                    {
                        string ext = Path.GetExtension(path).ToLower();

                        if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp")
                        {
                            if (richTextBoxContent != null)
                            {
                                richTextBoxContent.Clear();

                                using (Image img = Image.FromFile(path))
                                {
                                    Clipboard.SetImage(img);
                                    richTextBoxContent.Paste();
                                    Clipboard.Clear();
                                }
                            }
                        }
                        else
                        {
                            if (richTextBoxContent != null)
                            {
                                richTextBoxContent.Text = File.ReadAllText(path);
                            }
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        if (richTextBoxContent != null)
                        {
                            richTextBoxContent.Text = "Lỗi: Không có quyền truy cập vào file này!";
                        }
                    }
                    catch (Exception ex)
                    {
                        if (richTextBoxContent != null)
                        {
                            richTextBoxContent.Text = "Không thể đọc nội dung file: " + ex.Message;
                        }
                    }
                }
                else
                {
                    if (richTextBoxContent != null)
                    {
                        richTextBoxContent.Clear();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
