using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建一个新的进程以启动 Python 脚本
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "python";  // 指定 Python 解释器路径，如果已经在 PATH 中可以直接使用 "python"
                start.Arguments = "D:\\Repository\\test.py";  // 你想要执行的 Python 脚本路径
                start.UseShellExecute = false;  // 设置为 false 以重定向输出
                start.RedirectStandardOutput = true;  // 重定向输出
                start.RedirectStandardError = true;  // 重定向错误输出

                // 启动进程
                using (Process process = Process.Start(start))
                {
                    // 读取 Python 脚本的输出
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        MessageBox.Show(result);  // 将 Python 脚本的输出显示在消息框中
                    }

                    // 如果有错误输出
                    using (System.IO.StreamReader errorReader = process.StandardError)
                    {
                        string error = errorReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show("Error: " + error);  // 显示错误信息
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 捕获任何异常并显示错误信息
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinTextBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinLine1_Click(object sender, EventArgs e)
        {

        }
    }
}
