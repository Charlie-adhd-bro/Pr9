namespace Pr9
{
    public partial class pr9_3 : Form
    {
        public pr9_3()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";

            if (textBoxIndex.Text.Length == 0)
            {
                MessageBox.Show(
                    "Текстовое поле пустое, введите значения в поле",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;

            }
            if (!int.TryParse(textBoxIndex.Text, out int index) || index < 1)
            {
                MessageBox.Show(
                    "Введенно не число или неккоректное значение, введите еще раз",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            //ввод пользователя
            OddNumberSequence.SequenceProperty = index;

            int count = (int)numericCount.Value;
            List<int> numbers = [];

            for (int i = 0; i < count; i++)
            {
                numbers.Add(OddNumberSequence.SequenceProperty);
            }

            labelResult.Text += "Последовательность нечетных чисел (ввод пользователя): "
                + string.Join(", ", numbers);

            //с 5 индекса, 3 вызова (9, 11, 13)
            index = 5; count = 3;
            OddNumberSequence.SequenceProperty = index;
            numbers = [];

            for (int i = 0; i < count; i++)
            {
                numbers.Add(OddNumberSequence.SequenceProperty);
            }

            labelResult.Text += "\nПоследовательность нечетных чисел (с 5 индекса, 3 вызова) (9, 11, 13): "
                + string.Join(", ", numbers);

            //с 0 индекса, 5 вызова (-1, 1, 3, 5, 7)
            index = 0; count = 5;
            OddNumberSequence.SequenceProperty = index;
            numbers = [];

            for (int i = 0; i < count; i++)
            {
                numbers.Add(OddNumberSequence.SequenceProperty);
            }

            labelResult.Text += "\nПоследовательность нечетных чисел (с 0 индекса, 5 вызова) -1, 1, 3, 5, 7: "
                + string.Join(", ", numbers);

            //с -1 индекса, 5 вызова (-3, -1, 1, 3, 5)
            index = -1; count = 5;
            OddNumberSequence.SequenceProperty = index;
            numbers = [];

            for (int i = 0; i < count; i++)
            {
                numbers.Add(OddNumberSequence.SequenceProperty);
            }

            labelResult.Text += "\nПоследовательность нечетных чисел (с -1 индекса, 5 вызова) -3, -1, 1, 3, 5: "
                + string.Join(", ", numbers);

            //с 1 индекса, 5 вызова (1, 3, 5, 7, 9)
            index = 1; count = 5;
            OddNumberSequence.SequenceProperty = index;
            numbers = [];

            for (int i = 0; i < count; i++)
            {
                numbers.Add(OddNumberSequence.SequenceProperty);
            }

            labelResult.Text += "\nПоследовательность нечетных чисел (с 1 индекса, 5 вызова) 1, 3, 5, 7, 9: "
                + string.Join(", ", numbers);

            //с 0 индекса, 0 вызова 
            index = 0; count = 0;
            OddNumberSequence.SequenceProperty = index;
            numbers = [];

            for (int i = 0; i < count; i++)
            {
                numbers.Add(OddNumberSequence.SequenceProperty);
            }

            labelResult.Text += "\nПоследовательность нечетных чисел (с 0 индекса, 0 вызова): "
                + string.Join(", ", numbers);


            labelResult.Text += "\n\n\n";
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxIndex.Clear();
            numericCount.Value = 0;
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}