namespace Pr9
{
    class CustomArray
    {
        private int[] _array;
        private int _startIndex; 

        public CustomArray(int startIndex, int size)
        {
            this._startIndex = startIndex;
            _array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index < _startIndex || index >= _startIndex + _array.Length)
                {
                    throw new IndexOutOfRangeException
                        ($"Индекс должен быть в диапазоне [{_startIndex}, {_startIndex + _array.Length - 1}]");
                }
                return _array[index - _startIndex];
            }
            set
            {
                if (index < _startIndex || index >= _startIndex + _array.Length)
                {
                    throw new IndexOutOfRangeException
                        ($"Индекс должен быть в диапазоне [{_startIndex}, {_startIndex + _array.Length - 1}]");
                }
                _array[index - _startIndex] = value;
            }
        }

        public override string ToString()
        {
            var elements = new List<string>();
            for (int i = _startIndex; i < _startIndex + _array.Length; i++)
            {
                elements.Add($"{i} [{this[i]}]");
            }
            return $"Массив (индексы [{_startIndex}..{_startIndex + 
                _array.Length - 1}]): " + string.Join(", ", elements);
        }
    }
}
