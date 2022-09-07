

namespace MatrixLibrary
{
	public class Matrix
	{
        private int n;
        private int[,] array;

        // Создаем конструкторы матрицы
        public Matrix() { }
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }

        //Для работы вне класса
        public Matrix(int n)
        {
            this.n = n;
            array = new int[this.n, this.n];
        }
        public int this[int i, int j]
        {
            get
            {
                return array[i, j];
            }
            set
            {
                array[i, j] = value;
            }
        }

        // Ввод матрицы
        public void MatrixIn()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void MatrixInRandom()
        {
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this[i, j] = rand.Next() % 100;
                }
            }
        }

        // Вывод введенной матрицы
        public void MatrixOut()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }



        // Умножение матрицы на число
        public static Matrix MultByNumber(Matrix a, int num)
        {
            Matrix result = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    result[i, j] = a[i, j] * num;
                }
            }
            return result;
        }

        // Умножение матриц
        public static Matrix MultByMatrix(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }



        // перегрузка оператора умножения
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.MultByMatrix(a, b);
        }

        public static Matrix operator *(Matrix a, int b)
        {
            return Matrix.MultByNumber(a, b);
        }


        // Метод вычитания матриц
        public static Matrix Difference(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }

        // Перегрузка оператора вычитания
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return Matrix.Difference(a, b);
        }

        //Метод сложения матриц
        public static Matrix Sum(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }

        // Перегрузка сложения
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Sum(a, b);
        }

        //Метод транспонирования матриц
        public static Matrix Trans(Matrix a)
        {
            Matrix result = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    result[i, j] = a[j, i];
                }
            }
            return result;
        }

        //Метод возведения в степень матриц
        public static Matrix Pow(Matrix a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                a *= a;
                i++;
            }
            return a;
        }

        //Метод определения для матриц
        public static int Det(Matrix a)
        {
            if (a.N == 2)
            {
                return a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
            }
            if (a.N == 3)
            {
                return a[0, 0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * a[2, 0] +
                a[0, 2] * a[1, 0] * a[2, 1] - a[0, 2] * a[1, 1] * a[2, 0] -
                a[0, 0] * a[1, 2] * a[2, 1] - a[0, 1] * a[1, 0] * a[2, 2];
            }
            return 0;
        }


        // Деструктор Matrix
        ~Matrix()
        {
            Console.WriteLine("Очистка");
        }
    }
}