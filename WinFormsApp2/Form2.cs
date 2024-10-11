using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // 在构造函数中订阅 FormClosing 事件
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = "欢迎使用本应用！";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 弹出一个确认对话框
            DialogResult result = MessageBox.Show("你确定要退出吗？", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 如果用户选择 "否"，则取消关闭操作
            if (result == DialogResult.No)
            {
                e.Cancel = true; // 取消关闭
            }
            // 如果用户选择 "是"，则关闭窗体并退出程序
            else
            {
                // 可选择退出应用程序或执行其他操作
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
