using System;
using System.IO;
/*
    ┏┓ 
    ┃┃╱ ╲в
    ┃╱╱ ╲╲этом
    ╱╱ ╭╮ ╲╲доме
    ▔▏ ┗┛ ▕▔ мы
    ╱▔▔▔▔▔▔▔▔▔▔▔▔▔╲
    не любим душнить
  ╱╱  ┏┳┓  ╭╮  ┏┳┓  ╲╲ 
  ▔▏  ┗┻┛  ┃┃  ┗┻┛  ▕▔

 */



namespace Matrix
{
    //Класс матрицы.
    class Matrix
    {
        private int rows;
        private int cols;
        private double[,] m;

        //Конструктор для матрицы.
        public Matrix(int matrixRow,int matrixCol)
        {
            rows = matrixRow;
            cols = matrixCol;
            m = new double[rows, cols];
            
        }
        //Конструктор для ввода матрицы через файл.
        public Matrix(int matrixRow, int matrixCol, string fileName)
        {
            rows = matrixRow;
            cols = matrixCol;
            m = new double[rows, cols];

            //Считывае строчки из файла.
            string[] allstr = File.ReadAllLines(fileName);
            for (int i = 0; i < rows; i++)
            {
                string[] str = allstr[i].Split();
                if (str.Length != cols)
                {
                    //Если что-то не так, то просто заполняем нулями.
                    Console.WriteLine("Неверное количество элементов в строке");
                    Console.WriteLine("Ваша матрица будет заполнена нулями");
                    m = new double[rows, cols];
                    break;
                }
                else
                {
                    for (int j = 0; j < cols; j++)
                    {
                        //Присваиваем значения из строки 
                        if (!double.TryParse(str[j], out m[i, j]))
                        {
                            //Если что-то не так, то просто заполняем нулями.
                            Console.WriteLine("Пожалуйста вводите числа");
                            Console.WriteLine("Ваша матрица будет заполнена нулями");
                            m = new double[rows, cols];
                            break;
                        }

                    }
                }
            }
        }
        //Метод, выводящий матрицу.
        public void Write()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    Console.Write(m[i,j] + " ");

                }
                Console.WriteLine();

            }


        }
        //Метод, считывающий элементы матрицы по строчкам.
        public void Read()
        {
            Console.WriteLine("Введите элементы построчно через пробел");
            for (int i = 0; i < rows; i++)
            {
                string[] str = Console.ReadLine().Split();
                if (str.Length != cols)
                {
                    //Если в строке больше или меньше элементов чем нужно, то всю строчку вводим заново.
                    Console.WriteLine("Неверное количество элементов в строке");
                    i--;
                }
                else
                {
                    for (int j = 0; j < cols; j++)
                    {
                        //Если хоть один элемент в строчке - не число, то всю строчку вводим заново.
                        if (!double.TryParse(str[j], out m[i, j]))
                        {
                            Console.WriteLine("Пожалуйста вводите числа");
                            i--;
                            break;
                        }

                    }
                }
            }
        }
        //Метод, заполняющий матрицу рандомными элементами.
        public void RandomRead(int left, int right)
        {
            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    //Отдельно генерируем целую и дробную часть и убираем страшный хвост.
                    m[i, j] = r.Next(left, right) + r.NextDouble();
                    m[i, j] = Math.Round(m[i, j], 2);

                }
                Console.WriteLine();

            }


        }
        //Свойство, возвращающее количество строк.
        public int Rows
        {
            get
            {
                return rows;
            }
        }
        //Свойство, возвращающее количество столбцов.
        public int Cols
        {
            get
            {
                return cols;
            }
        }
        //Свойство, возвращающее массив с элементами матрицы.
        public double[,] M
        {
            get 
            {
                return m;
            }
        }
        //Свойство, чтобы обращаться к элементам матрицы через скобки.
        public double this[int i, int j]
        {
            get
            {
                return m[i, j];
            }
            set
            {
                m[i, j] = value;
            }
        }
        //Метод, считающий след квадратной матрицы.
        public double Trace() 
        {
                double trace = 0;
                for (int i = 0; i < rows; i++)
                {
                    trace += m[i, i];
                }
                return trace;
        }
        //Метод, считающий определитель квадратной матрицы через разложение по строке.
        public double Det(int n, double[,] Mat) 
        {
            double d = 0;
            int k, i, j, subi, subj;
            double[,] SUBMat = new double[n, n];

            //Вдруг кто-то захочет посчитать матрицу из одного элемента.
            if (n == 1) return Mat[0, 0];

            //Выход из рекурсии когда дойдем до матрицы 2х2.
            if (n == 2)
            {
                return ((Mat[0, 0] * Mat[1, 1]) - (Mat[1, 0] * Mat[0, 1]));
            }
            else
            {
                for (k = 0; k < n; k++)
                {
                    subi = 0;
                    for (i = 1; i < n; i++)
                    {
                        subj = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            SUBMat[subi, subj] = Mat[i, j];
                            subj++;
                        }
                        subi++;
                    }
                    d = d + (Math.Pow(-1, k) * Mat[0, k] * Det(n - 1, SUBMat));
                }
            }
            return d;
        }
        //Метод, транспонирующий текущую матрицу. Назван просто Т в честь условного обозначения.
        public void T()
        {

            double[,] mt = new double[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mt[j, i] = m[i, j];
                }
            }
            int temp = rows;
            rows = cols;
            cols = temp;
            m = mt;

        }
        //Метод, прибавляющий к текущей матрице новую.
        public Matrix Sum(Matrix b)
        {
            Matrix c = new Matrix(rows, cols);
            if (b.Rows == rows && b.Cols == cols) //потом уберу
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        c[i, j] = m[i, j] + b[i, j];
                    }
                }
                
            }
            return c;
        }
        //Метод, вычитающий из текущей матрицы новую.
        public Matrix Subst(Matrix b)
        {
            Matrix c = new Matrix(rows, cols);

           for (int i = 0; i < rows; i++)
           {
                for (int j = 0; j < cols; j++)
                {
                    c[i, j] = m[i, j] - b[i, j];
                }
           }

            
            return c;
        }
        //Метод, умножающий матрицу на число.
        public Matrix NumberMult(double b)
        {
            Matrix c = new Matrix(rows, cols);
            
            for (int i = 0; i < rows; i++){
                for (int j = 0; j < cols; j++)
                {
                    c[i, j] = m[i, j] * b;
                }
            }

            return c;
        }
        //Метод, умножающий матрицы.Текущая умножается на новую.
        public Matrix MatrixMult(Matrix b)
        {
            Matrix c = new Matrix(rows, b.cols);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            //Правило умножения матриц и все такое.
                            c[i, j] += m[i, k] * b[k, j];
                        }
                    }
                }

            
            return c;
        }
        //Метод, удаляющий последний столбец матрицы.
        public Matrix ColReduce()
        {
            Matrix newM = new Matrix(rows, rows);
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    newM[i, j] = this[i, j];
                }

            }
            return newM;
        }
        //Метод, выделяющий последний столбец матрицы в отдельную матрицу.
        public Matrix GetLastCol()
        {
            Matrix newM = new Matrix(rows,1);
            for (int i = 0; i < rows; i++)
            {
                newM[i,0] = this[i, cols-1];
            }
            return newM;

        }
        //Метод для решения системы уравнений методом крамера.
        public double[] Cramer()
        {
            double[] xs = new double[rows];

                //Считаем определитель исходной матрицы без последнего столбца.
                double mainDet = Det(rows, this.ColReduce().M);
                for (int q = 0; q < rows; q++)
                {
                    //Создаем копию исохдной матрицы без последнего столбца и выносим последний столбец в отдельную.
                    Matrix tempM = this.ColReduce();
                    Matrix lastCol = this.GetLastCol();
                    for(int i = 0; i < rows; i++)
                    {
                        //Меняем столбец с последним столбцом исходной матрицы.
                        tempM[i, q] = lastCol[i, 0];
                    }

                    //Находим х и превращаем -0 в 0.
                    xs[q] = Det(rows, tempM.M) / mainDet;
                    if (xs[q] == -0) { xs[q] = 0;}
                }
            
            return xs;
        }
        
    }

    
    class Program
    {
        //Метод для вывода списка команд.
        public static void Menu()
        {
            Console.WriteLine("Добро пожаловать в матричный калькулятор");
            Console.WriteLine("Выберите команду");
            Console.WriteLine("1) Ввести матрицу");
            Console.WriteLine("2) Посчитать след (только для квадратных)");
            Console.WriteLine("3) Посчитать определитель (только для квадратных)");
            Console.WriteLine("4) Транспонировать матрицу");
            Console.WriteLine("5) Умножить матрицу на число");
            Console.WriteLine("6) Умножить матрицу на другую матрицу");
            Console.WriteLine("7) Прибавить к матрице другую матрицу");
            Console.WriteLine("8) Вычесть из матрицы другую матрицу");
            Console.WriteLine("9) Метод крамера (только для квадратных, если не считать столбец y)");
            Console.WriteLine("10) Вывести матрицу");
            Console.WriteLine("11) Выйти");
            Console.WriteLine();

        }
        //Метод для ввода матрицы, который объединяет 3 способа ввода и проверяет нужнеые ограничения.
        public static Matrix EnterMatrix()
        {
            int rows = 0, cols = 0;
            Matrix Mat = new Matrix(1,1);
            

            bool flag = false;
            //Цикл который работает пока мы не введем правильный размер.
            while (!flag) {
                Console.WriteLine("Введите размер матрицы (не больше 10х10)");

                Console.WriteLine("Сколько строк?");
                bool rowsbool = int.TryParse(Console.ReadLine(), out rows);
                Console.WriteLine("Сколько столбцов?");
                bool colsbool = int.TryParse(Console.ReadLine(), out cols);

                //Проверка верно введенного размера.
                if (colsbool && rowsbool && rows * cols <= 100)
                {
                    //Выбор способа ввода матрицы.
                    Console.WriteLine("Как вы хотите задать элементы?");
                    Console.WriteLine("1) Ввести руками");
                    Console.WriteLine("2) Ввести из файла");
                    Console.WriteLine("3) Рандом");
                    
                    int ans = 0;
                    bool y = int.TryParse(Console.ReadLine(), out ans);
                    if (ans == 1)
                    {
                        //Считываем матрицу с клавиатуры.
                        flag = true;
                        Mat = new Matrix(rows, cols);
                        Mat.Read();
                    }
                    else if (ans == 2)
                    {
                        //Считываем матрицу из файла.
                        Console.WriteLine("Введите полный путь до файла");
                        string fileName = Console.ReadLine();
                        //Проверяем, что файл существует.
                        if (File.Exists(fileName))
                        {
                            flag = true;
                            Mat = new Matrix(rows, cols, fileName);
                        }
                        else
                        {
                            Console.WriteLine("Неверный путь до файла");
                        }
                    }
                    else if (ans == 3)
                    {
                        //Заполняем матрицу рандомными элементами.
                        flag = true;
                        int left=0,right = 0;

                        Console.WriteLine("Введите границы рандома через пробел");
                        string[] str = Console.ReadLine().Split();

                        bool leftbool = int.TryParse(str[0], out left);
                        bool rightbool = int.TryParse(str[1], out right);

                        //Проверяем, что границы это числа.
                        if (leftbool && rightbool)
                        {
                            //Меняем границы если пользователь ошибся в их порядке.
                            if (left > right)
                            {
                                int temp = right;
                                right = left;
                                left = temp;
                            }

                            Mat = new Matrix(rows, cols);
                            Mat.RandomRead(left, right);
                        }
                        else
                        {
                            Console.WriteLine("Неправильные границы (2 целых числа)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверная команда");
                    }

                }
                else
                {
                    Console.WriteLine("Неправильный размер");
                }
               
            }
            return Mat;
        }

        //Главный метод.
        static void Main(string[] args)
        {
            int n=0;
            Matrix m = new Matrix(1,1);
            //Выходис из цикла если пользватель ввел 11.
            while (n != 11)
            {
                //Вызываем меню и считываем команду.
                Menu();
                bool x = int.TryParse(Console.ReadLine(), out n);
                if (x && n>0 && n < 12)
                {
                    //Выполняем нужное действие.
                    switch (n)
                    {
                        case 1:
                            m = EnterMatrix(); 
                            break;
                        case 2:
                            if (m.Rows == m.Cols)
                            {
                                Console.WriteLine(m.Trace());
                            }
                            else
                            {
                                Console.WriteLine("У вас не квадратная матрица");
                            }
                            break;
                        case 3:
                            if (m.Rows == m.Cols)
                            {
                                Console.WriteLine(m.Det(m.Rows, m.M)) ;
                            }
                            else
                            {
                                Console.WriteLine("У вас не квадратная матрица");
                            }
                            break;
                        case 4:
                            m.T();
                            m.Write();
                            break;
                        case 5:
                            Console.WriteLine("Введите число на которое хотите умножить");
                            double number;
                            bool numberbool = double.TryParse(Console.ReadLine(), out number);
                            if (numberbool)
                            {
                                m = m.NumberMult(number);
                                m.Write();
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели не число");
                            }
                            break;
                        case 6:
                            Console.WriteLine("Введите вторую матрицу");
                            Matrix Multm = EnterMatrix();
                            if (m.Cols == Multm.Rows)
                            {
                                m = m.MatrixMult(Multm);
                                m.Write();
                            }
                            else
                            {
                                Console.WriteLine("Такие матрицы нельзя умножать");
                            }
                            break;
                        case 7:
                            Console.WriteLine("Введите вторую матрицу");
                            Matrix Summ = EnterMatrix();
                            if (m.Cols == Summ.Cols && m.Rows == Summ.Cols)
                            {
                                m = m.Sum(Summ);
                                m.Write();
                            }
                            else
                            {
                                Console.WriteLine("Такие матрицы нельзя складывать");
                            }
                            break;
                        case 8:
                            Console.WriteLine("Введите вторую матрицу");
                            Matrix Substm = EnterMatrix();
                            if (m.Cols == Substm.Cols && m.Rows == Substm.Cols)
                            {
                                m = m.Subst(Substm);
                                m.Write();
                            }
                            else
                            {
                                Console.WriteLine("Такие матрицы нельзя вычитать");
                            }
                            break;
                        case 9:
                            if (m.Cols == m.Rows + 1 && m.Det(m.Rows, m.ColReduce().M)!=0)
                            {
                                double[] xs = m.Cramer();
                                //Красиво выводим решение системы.
                                Console.WriteLine("Решения системы:");
                                for(int el =0; el< xs.Length;el++)
                                {
                                    Console.WriteLine("x{0} = {1} ",el+1,xs[el]);
                                }
                                Console.WriteLine();
                            }
                            else
                            {
                              Console.WriteLine("Матрица неправильного размера или вырожденная");
                            }
                            break;
                        case 10:
                            m.Write();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверная команда");
                }
            }


        }
    }
}
