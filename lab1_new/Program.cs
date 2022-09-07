using MatrixLibrary;

class MainProgram
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность матрицы: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Matrix mass1 = new Matrix(size);
        Matrix mass2 = new Matrix(size);
        


        Console.WriteLine("1. Ввод вручную\n2. Автоматическое заполнение");
        string answer = Console.ReadLine();

            if (answer != null)
            {
                if (answer == "1")
                {

                    Console.WriteLine("ввод Матрица А: ");
                    mass1.MatrixIn();

                    Console.WriteLine("Ввод Матрица B: ");
                    mass2.MatrixIn();

                    Console.WriteLine("Матрица А: ");
                    mass1.MatrixOut();

                    Console.WriteLine("\nМатрица В: ");
                    mass2.MatrixOut();
                }
                if (answer == "2")
                {
                    Console.WriteLine("Матрица А: ");
                    mass1.MatrixInRandom();
                    mass1.MatrixOut();

                    Console.WriteLine("\nМатрица Б: ");
                    mass2.MatrixInRandom();
                    mass2.MatrixOut();
                }
            if (answer != "1" && answer != "2") { Console.WriteLine("Введен некорректный ответ!"); return; }
            }
        


       // Инициализация
       

        

        Console.WriteLine("\nСложение матриц А и Б: ");
        Matrix resSum = new Matrix(size);
        resSum = (mass1 + mass2);
        resSum.MatrixOut();

        Console.WriteLine("\nВычитание матриц А и Б: ");
        Matrix resDiff = new Matrix(size);
        resDiff = (mass1 - mass2);
        resDiff.MatrixOut(); 
        
        Console.WriteLine("\nЧисло, на которое нужно умножить матрицу А: ");
        Matrix resMultByNum = new Matrix(size);
        resMultByNum = mass1 * Convert.ToInt32(Console.ReadLine());
        resMultByNum.MatrixOut();

        Console.WriteLine("\nУмножение матриц А и Б: ");
        Matrix resMult = new Matrix(size);
        resMult = (mass1 * mass2);
        resMult.MatrixOut();

        Console.WriteLine("\nТранспонирование матрицы А: ");
        Matrix resTrans = new Matrix(size);
        resTrans = Matrix.Trans(mass1);
        resTrans.MatrixOut();

        Console.WriteLine("\nЧисло, на которое нужно возвести в степень матрицу А: ");
        Matrix resPow = new Matrix(size);
        resMultByNum = Matrix.Pow(mass1, Convert.ToInt32(Console.ReadLine()));
        resMultByNum.MatrixOut();

        Console.WriteLine("\nОпределитель матрицы А: ");
        int resDet = Matrix.Det(mass1);
        Console.WriteLine(resDet);

        return;
    }
}
