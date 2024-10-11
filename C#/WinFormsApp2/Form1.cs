namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ���� FormClosing �¼�
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��֤�û���¼��Ϣ���˴������¼�ɹ���
            bool isAuthenticated = true;

            if (isAuthenticated)
            {
                // ʵ�����Ӵ��� Form2
                Form2 childForm = new Form2();

                // ��ʾ�Ӵ���
                childForm.Show();

                // �رյ�ǰ������
                this.Hide();
            }
            else
            {
                MessageBox.Show("��¼ʧ�ܣ������ԣ�");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // �رյ�ǰ���ڣ��ᴥ�� FormClosing �¼�
        }

        // FormClosing �¼��������
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ����һ��ȷ�϶Ի���
            DialogResult result = MessageBox.Show("��ȷ��Ҫ�˳���", "�˳�ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ����û�ѡ�� "��"����ȡ���رղ���
            if (result == DialogResult.No)
            {
                e.Cancel = true; // ȡ���ر�
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
