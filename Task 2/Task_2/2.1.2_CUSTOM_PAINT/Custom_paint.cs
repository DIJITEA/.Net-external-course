using used_frequently;

namespace _2._1._2_CUSTOM_PAINT
{
    public class Custom_paint
    {
        private static string[] _figures;

        public static string[] figures
        {
            set => _figures = value;
            get => _figures;
        }

        public static void Main()
        {
            //Console.Clear();
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Вывести фигуры");
            Console.WriteLine("3. Очистить холст");
            Console.WriteLine("4. Выход");
            int switcherInput = UsedFrequently.Try2ParseLessThenN(4);
            switch (switcherInput)
            {
                case 1:
                    Console.WriteLine();
                    Figure.Main();
                    break;
                case 2:
                    Console.WriteLine();
                    ShowFigures();
                    Console.WriteLine();
                    Main();
                    break;
                case 3:
                    Console.WriteLine();
                    ClearFigures();
                    Main();
                    break;
                case 4:
                    Console.WriteLine();
                    break;
            }
        }

        public static void ShowFigures()
        {
            if (figures != null)
            {
                foreach (string f in figures)
                {
                    Console.WriteLine(f);
                }
            }
            else Console.WriteLine("No figures");
        }

        public static void ClearFigures()
        {
            figures = null;
        }
    }
    public class Figure
    {
        public static void Main()
        {
            Console.WriteLine("Выберите тип фигуры:");
            Console.WriteLine("    1.Круг");
            Console.WriteLine("    2.Кольцо");
            Console.WriteLine("    3.Линия");
            Console.WriteLine("    4.Треугольник");
            Console.WriteLine("    5.Квадрат");
            Console.WriteLine("    6.Прямоугольник");
            int switcherInput = UsedFrequently.Try2ParseLessThenN(6);
            switch (switcherInput)
            {
                case 1:
                    Console.WriteLine();

                    Curcle.Main();
                    Custom_paint.Main();
                    break;
                case 2:
                    Console.WriteLine();

                    Ring.Main();
                    Custom_paint.Main();
                    break;
                case 3:
                    Console.WriteLine();

                    Line.Main();
                    Custom_paint.Main();
                    break;
                case 4:
                    Console.WriteLine();

                    Triangle.Main();
                    Custom_paint.Main();
                    break;
                case 5:
                    Console.WriteLine();

                    Square.Main();
                    Custom_paint.Main();
                    break;
                case 6:
                    Console.WriteLine();

                    Rectangle.Main();
                    Custom_paint.Main();
                    break;
            }
        }

        public static void FigureArray(string figure)
        {
            string[] figureArray = Custom_paint.figures;
            if (figureArray == null)
            {
                string[] temp = { figure };
                Custom_paint.figures = temp;
            }
            else
            {
                Array.Resize(ref figureArray, figureArray.Length + 1);
                figureArray[figureArray.Length - 1] = figure;
                Custom_paint.figures = figureArray;
            }

        }
    }
}
