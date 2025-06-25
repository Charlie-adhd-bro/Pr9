
namespace Pr9
{
    internal class MySymbol
    {
        private char _symbol;

        public MySymbol(char symbol)
        {
            this.Symbol = symbol;
        }

        public char Symbol
        {
            get { return _symbol; }
            set
            {
                if (IsValidSymbol(value))
                {
                    _symbol = value;
                }
                else
                {
                    MessageBox.Show($"Введенно значение: {value}." +
                        $"\nЗначение должно быть в диапазоне от 'А' до 'z'.");
                }
            }
        }

        private bool IsValidSymbol(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public override string ToString()
        {
            if (IsValidSymbol(_symbol)) 
                return $"Вы ввели: {_symbol}"
                     + ", код символа: " + (int)_symbol + "\n";
            else return "Введенно значение за диапазоном\n";

        }
    }
}