namespace _02_Indexers
{
    internal class Matrix
    {
        private readonly int[,] _numbers;

        public Matrix(int matrixSize)
        {
            _numbers = new int[matrixSize, matrixSize];

            var number = 1;
            for (var i = 0; i < matrixSize; i++)
            {
                for (var j = 0; j < matrixSize; j++)
                {
                    _numbers[i, j] = number++;
                }
            }
        }

        public int Size
        {
            get { return _numbers.Rank; }
        }

        public int this[int i, int j]
        {
            get
            {
                return _numbers[i, j];
            }
            set
            {
                _numbers[i, j] = value;
            }
        }
    }
}