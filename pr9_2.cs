namespace Pr9
{
    public partial class pr9_2 : Form
    {
        public pr9_2()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";

            if (textBoxSize.Text.Length == 0
                || textBoxInsert.Text.Length == 0)
            {
                MessageBox.Show(
                    "Одно из текстовых полей пустое, введите значения во все поля",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;

            }
            if (!int.TryParse(textBoxSize.Text, out int size)
                || !int.TryParse(textBoxInsert.Text, out int insert))
            {
                MessageBox.Show(
                    "Введенно не число, введите корректые значения",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }


            //ввод пользователя 3 
            ArrayAndNumber array = new(size); // {11 12 13}
            labelResult.Text += array.ToString();

            labelResult.Text += array.Number + "\n";
            labelResult.Text += array.Number + "\n";
            labelResult.Text += array.Number + "\n";
            //{ 11 12 13}

            array.Number = 999;   //{ 11 12 999}

            labelResult.Text += array.ToString(); //{ 11 12 999}

            labelResult.Text += array.Number + "\n";            
            //{ 11 }
            array.Number = -99;   //{ -99}

            labelResult.Text += array.ToString(); //{ -99 12 999}


            labelResult.Text += "\n\n\n";
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSize.Clear();
            textBoxInsert.Clear();

            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
