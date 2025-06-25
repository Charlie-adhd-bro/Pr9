namespace Pr9
{
    public partial class pr9_1 : Form
    {
        public pr9_1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";

            if (textBoxSymbol.Text.Length == 0)
            {
                MessageBox.Show(
                        "Текстовое поле пустое, введите значения в поле",
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;

            }

            //ввод пользователя
            char symbol = textBoxSymbol.Text[0];
            MySymbol mySymbol = new(symbol);
            labelResult.Text += mySymbol.ToString();


            mySymbol.Symbol = 'C';
            labelResult.Text += mySymbol.ToString();

            mySymbol.Symbol = '#';
            labelResult.Text += mySymbol.ToString();

            //перед границой A
            mySymbol = new('@');
            labelResult.Text += mySymbol.ToString();

            //граница A
            mySymbol = new('A');
            labelResult.Text += mySymbol.ToString();

            //после границы A
            mySymbol = new('B');
            labelResult.Text += mySymbol.ToString();

            //граница z
            mySymbol = new('z');
            labelResult.Text += mySymbol.ToString();

            //перед границей z
            mySymbol = new('y');
            labelResult.Text += mySymbol.ToString();

            //после границы z
            mySymbol = new('{');
            labelResult.Text += mySymbol.ToString();

            //символ внутри диапазона
            mySymbol = new('G');
            labelResult.Text += mySymbol.ToString();

            labelResult.Text += mySymbol.Symbol;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSymbol.Clear();

            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
