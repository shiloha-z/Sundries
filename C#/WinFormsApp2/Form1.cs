namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 订阅 FormClosing 事件
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 验证用户登录信息（此处假设登录成功）
            bool isAuthenticated = true;

            if (isAuthenticated)
            {
                // 实例化子窗体 Form2
                Form2 childForm = new Form2();

                // 显示子窗体
                childForm.Show();

                // 关闭当前主窗体
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败，请重试！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // 关闭当前窗口，会触发 FormClosing 事件
        }

        // FormClosing 事件处理程序
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 弹出一个确认对话框
            DialogResult result = MessageBox.Show("你确定要退出吗？", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 如果用户选择 "否"，则取消关闭操作
            if (result == DialogResult.No)
            {
                e.Cancel = true; // 取消关闭
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
