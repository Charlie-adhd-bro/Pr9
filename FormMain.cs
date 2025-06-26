namespace Pr9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr9_1 FormMain = new();
            FormMain.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr9_2 FormMain = new();
            FormMain.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr9_3 FormMain = new();
            FormMain.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr9_4 FormMain = new();
            FormMain.Show();
        }
    }
}
