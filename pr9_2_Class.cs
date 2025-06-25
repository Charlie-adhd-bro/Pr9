namespace Pr9
{
    internal class ArrayAndNumber
    {
        private int[] _array;
        private int _index=-1;

        public ArrayAndNumber(int size)
        {
            _array = new int[size];
            FillArray();
        }

        private int[] FillArray()
        {
            int num = 11;
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = num;
                num++;
            }
            return _array;
        }

        public int Number
        {
            get {
                //MessageBox.Show($"{ _index}");
                _index = (_index + 1) % _array.Length;
                return _array[_index];
            }
            set
            {
               // MessageBox.Show($"{_index}");
                /*if (_index >= 0 && _index < _array.Length)*/
                    _array[_index] = value;
                /*else
                    MessageBox.Show(
                        "Индекс вне диапазона массива",
                        "Ошибка",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );*/
            }
        }


        public override string ToString()
        {
            return "Массив: " + string.Join(", ", _array) + "\n";
        }
    }
}