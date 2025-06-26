namespace Pr9
{
    class OddNumberSequence
    {
        //private static int _startIndex = -1; 
        private static int _currentIndex = 1;   

        public static int SequenceProperty
        {
            get
            {
                int result = 2 * _currentIndex - 1;
                _currentIndex++;
                return result;
            }
            set
            {
               // _startIndex = value;
                _currentIndex = value;
            }
        }
    }
}