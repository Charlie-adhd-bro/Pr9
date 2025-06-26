using System.Threading.Tasks;

namespace Pr9
{
    public partial class pr9_4 : Form
    {
        public pr9_4()
        {
            InitializeComponent();
        }

        public void TestResult(int startIndex, int size, int valueTest, int userInsert)
        {

            CustomArray array = new CustomArray(startIndex, size);

            for (int i = startIndex; i < startIndex + size; i++)
            {
                array[i] = i + 10;
            }

            try
            {
                int value = array[valueTest];
                labelResult.Text += $"Значение по индексу {valueTest}: {value}";
                labelResult.Text += "\n" + array.ToString() + "\n";
                array[valueTest] = userInsert;
            }
            catch (IndexOutOfRangeException ex)
            {
                labelResult.Text += $"Ошибка при доступе к индексу {valueTest}: {ex.Message}\n";
            }

            labelResult.Text += array.ToString() + "\n\n";


        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";

            if (string.IsNullOrWhiteSpace(textBoxIndex.Text) 
                || string.IsNullOrWhiteSpace(textBoxIndexInsert.Text) 
                || string.IsNullOrWhiteSpace(textBoxValueInsert.Text))
            {
                MessageBox.Show(
                    "Одно из текстовых полей пустое, введите значения во все поля",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!int.TryParse(textBoxIndex.Text, out int startIndex) 
                || !int.TryParse(textBoxIndexInsert.Text, out int indexInsert)
                || !int.TryParse(textBoxValueInsert.Text, out int valueInsert))
            {
                MessageBox.Show(
                    "Введено не число, введите еще раз",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            //ввод пользователя 
            int size = (int)numericCount.Value;
            TestResult(startIndex, size, indexInsert, valueInsert);


            //выход за пределы массива (меньше)
            labelResult.Text += "выход за пределы массива (меньше):\n";
            TestResult(2, 3, 1, valueInsert);

            //выход за пределы массива (больше)
            labelResult.Text += "выход за пределы массива (больше):\n";
            TestResult(2, 3, 5, valueInsert);

            //граница массива 
            labelResult.Text += "граница массива:\n";
            TestResult(2, 3, 2, valueInsert);

            //середина массива 
            labelResult.Text += "середина массива:\n";
            TestResult(-1, 6, 2, valueInsert);

            labelResult.Text += "\n\n\n";

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxIndex.Clear();
            textBoxIndexInsert.Clear();
            textBoxValueInsert.Clear();
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