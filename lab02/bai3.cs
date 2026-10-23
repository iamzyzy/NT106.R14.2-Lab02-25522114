using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab02
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string[] inputLines;
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string inputPath = "input3.txt";

            try
            {
                if (File.Exists(inputPath))
                {
                    inputLines = File.ReadAllLines(inputPath);
                    richTextBox1.Text = string.Join(Environment.NewLine, inputLines);
                    MessageBox.Show("Đọc file input3.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file input3.txt trong thư mục chạy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            if (inputLines == null || inputLines.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm nút 'Đọc File' trước khi tính toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string outputPath = "output3.txt";
            List<string> results = new List<string>();

            foreach (string line in inputLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    double result = TinhToanBieuThuc(line);
                    string outputLine = line + " = " + result;
                    results.Add(outputLine);
                }
                catch (Exception)
                {
                    results.Add(line + " = Lỗi biểu thức");
                }
            }

            try
            {
                File.WriteAllLines(outputPath, results);
                richTextBox1.Text = File.ReadAllText(outputPath);

                MessageBox.Show("Đã tính toán và ghi kết quả xuống file output3.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double TinhToanBieuThuc(string expr)
        {
            expr = expr.Replace('–', '-').Replace('—', '-');
            var tokens = Tokenize(expr);
            var postfix = ToPostfix(tokens);
            return EvaluatePostfix(postfix);
        }

        private List<string> Tokenize(string expr)
        {
            var tokens = new List<string>();
            string number = "";
            bool expectUnary = true; 

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (char.IsWhiteSpace(c)) continue;

                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                    expectUnary = false;
                }
                else if ((c == '+' || c == '-') && expectUnary)
                {
                    number += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        tokens.Add(number);
                        number = "";
                    }

                    if (c == '(')
                    {
                        expectUnary = true;
                    }
                    else if (c == ')')
                    {
                        expectUnary = false;
                    }
                    else if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        expectUnary = true;
                    }

                    tokens.Add(c.ToString());
                }
            }

            if (!string.IsNullOrEmpty(number))
            {
                tokens.Add(number);
            }

            return tokens;
        }

        private List<string> ToPostfix(List<string> tokens)
        {
            var output = new List<string>();
            var ops = new Stack<string>();

            Dictionary<string, int> precedence = new Dictionary<string, int>()
            {
                { "+", 1 }, { "-", 1 },
                { "*", 2 }, { "/", 2 }
            };

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    output.Add(token);
                }
                else if (token == "(")
                {
                    ops.Push(token);
                }
                else if (token == ")")
                {
                    while (ops.Count > 0 && ops.Peek() != "(")
                    {
                        output.Add(ops.Pop());
                    }
                    if (ops.Count > 0 && ops.Peek() == "(")
                    {
                        ops.Pop();
                    }
                }
                else if (precedence.ContainsKey(token))
                {
                    while (ops.Count > 0 && precedence.ContainsKey(ops.Peek()) && precedence[ops.Peek()] >= precedence[token])
                    {
                        output.Add(ops.Pop());
                    }
                    ops.Push(token);
                }
            }

            while (ops.Count > 0)
            {
                output.Add(ops.Pop());
            }

            return output;
        }

        private double EvaluatePostfix(List<string> postfix)
        {
            var stack = new Stack<double>();

            foreach (var token in postfix)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    if (stack.Count < 2) throw new InvalidOperationException("Biểu thức không hợp lệ");
                    double b = stack.Pop();
                    double a = stack.Pop();
                    switch (token)
                    {
                        case "+": stack.Push(a + b); break;
                        case "-": stack.Push(a - b); break;
                        case "*": stack.Push(a * b); break;
                        case "/":
                            if (b == 0) throw new DivideByZeroException("Lỗi chia cho 0");
                            stack.Push(a / b);
                            break;
                    }
                }
            }

            return stack.Count > 0 ? stack.Pop() : 0;
        }
    }

}
