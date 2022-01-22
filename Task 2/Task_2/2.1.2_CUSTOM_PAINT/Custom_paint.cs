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


    class Curcle
    {
        private static string _figureName = "Круг";
        public static string figureName { get { return _figureName; } set { _figureName = value; } }
        private static int _x;
        public static int x { get { return _x; } set { _x = value; } }

        private static int _y;
        public static int y { get { return _y; } set { _y = value; } }

        private static int _r;
        public static int r { get { return _r; } set { _r = value; } }

        private static double _СFerence;

        private static double _СArea;
        public static double СArea { get { return _СArea; } set { _СArea = value; } }

        private static int[] _center = new int[2];
        public static int[] center { get { return _center; } set { _center = value; } }



        public static void Main()
        {
            getCenter();
            getRadius();
            getСircumference(_r);
            getCircleArea(_r);
            Figure.FigureArray(cOutput());
        }

        public static int[] getCenter()
        {

            Console.Write("Введите 'x': ");
            _x = UsedFrequently.Try2Parse();
            _center[0] = _x;

            Console.Write("Введите 'y': ");
            _y = UsedFrequently.Try2Parse();
            _center[1] = _y;
            return _center;
        }
        public static int getRadius()
        {
            Console.Write("Введите радиус: ");
            _r = UsedFrequently.Try2Parse();
            return _r;
        }

        public static double getСircumference(int radius)
        {
            _СFerence = 2 * 3.14 * radius;
            return _СFerence;
        }

        public static double getCircleArea(int radius)
        {
            _СArea = 3.14 * (radius * radius);
            return _СArea;
        }

        public static string cOutput()
        {
            return "------------- \n" +
                   $"Фигура: {_figureName} \n" +
                   $"Координаты центра: x = {_center[0]} y = {_center[1]} \n" +
                   $"Радиус: {_r} \n" +
                   $"Длинна окружности: {_СFerence} \n" +
                   $"Площадь окружности: {_СArea} \n" +
                   "------------- \n";
        }
    }

    class Ring : Curcle
    {

        private static double _inСFerence;
        private static double _outСFerence;
        private static double _rArea;
        public static new void Main()
        {
            figureName = "Кольцо";
            getCenter();
            getRingArea();
            Figure.FigureArray(rOutput());
        }
        public static double getRingArea()
        {
            Console.WriteLine("Внутренний радиус");
            getRadius();
            _rArea = getCircleArea(r);
            _inСFerence = getСircumference(r);

            Console.WriteLine("Внешний радиус");
            getRadius();
            _rArea = _rArea - getCircleArea(r);
            _outСFerence = getСircumference(r);

            return _rArea;
        }


        public static string rOutput()
        {
            return
                  "------------- \n" +
                  $"Фигура: {figureName} \n" +
                  $"Координаты центра: x = {center[0]} y = {center[1]} \n" +
                  $"Радиус: {r} \n" +
                  $"Длинна внутренней окружности: {_inСFerence} \n" +
                  $"Длинна внешней окружности: {_outСFerence} \n" +
                  $"Площадь кольца: {_rArea} \n" +
                  "------------- \n";
        }
    }
    class Line
    {
        private static string _figureName;
        public static string figureName { get { return _figureName; } set { _figureName = value; } }

        private static double _x;
        private static double _y;

        public static double x { get { return _x; } set { _x = value; } }
        public static double y { get { return _y; } set { _y = value; } }

        private static double _x1;
        private static double _y1;

        public static double x1 { get { return _x1; } set { _x1 = value; } }
        public static double y1 { get { return _y1; } set { _y1 = value; } }

        private static double _lineLength;

        public static double lineLength { get { return _lineLength; } set { _lineLength = value; } }

        public static void Main()
        {
            Console.WriteLine("Координаты первой точки:");
            Console.Write("   x: ");
            x = getCoordinateValue();
            Console.Write("   y: ");
            y = getCoordinateValue();
            Console.WriteLine("Координаты второй точки:");
            Console.Write("   x: ");
            x1 = getCoordinateValue();
            Console.Write("   y: ");
            y1 = getCoordinateValue();
            lineLength = getLineLength(x, y, x1, y1);
            if (lineLength == 0)
            {
                Figure.FigureArray(pOutput());
            }
            else
            {
                Figure.FigureArray(lOutput());
            }
        }

        public static double getLineLength(double x, double y, double x1, double y1)
        {
            return Math.Round(Math.Sqrt((Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2))), 2, MidpointRounding.AwayFromZero);
        }

        public static double getCoordinateValue()
        {
            return UsedFrequently.Try2Parse();
        }
        public static string pOutput()
        {
            figureName = "Точка";
            return $"Фигура: {figureName} Координаты центра: x = {x} y = {y}";
        }
        public static string lOutput()
        {
            figureName = "Линия";
            return "------------- \n" +
                   $"Фигура: {figureName} \n" +
                   $"Координаты первой точки: x = {x} y = {y} \n" +
                   $"Координаты второй точки: x = {x1} y = {y1} \n" +
                   $"Длинна линии: {lineLength}" +
                   "------------- \n";

        }
    }

    class Triangle : Line
    {
        private static double _x2;
        private static double _y2;

        public static double x2 { get { return _x2; } set { _x2 = value; } }
        public static double y2 { get { return _y2; } set { _y2 = value; } }

        private static double _lineLengthB;
        private static double _lineLengthC;

        public static double lineLengthB { get { return _lineLengthB; } set { _lineLengthB = value; } }
        public static double lineLengthC { get { return _lineLengthC; } set { _lineLengthC = value; } }

        private static double[] _angles = new double[3];
        public static double[] angles { get { return _angles; } set { _angles = value; } }

        private static double _triangleArea;

        public static new void Main()
        {
            Console.WriteLine("Координаты первой точки:");
            Console.Write("   x: ");
            x = getCoordinateValue();
            Console.Write("   y: ");
            y = getCoordinateValue();
            Console.WriteLine("Координаты второй точки:");
            Console.Write("   x: ");
            x1 = getCoordinateValue();
            Console.Write("   y: ");
            y1 = getCoordinateValue();
            Console.WriteLine("Координаты третьей точки:");
            Console.Write("   x: ");
            x2 = getCoordinateValue();
            Console.Write("   y: ");
            y2 = getCoordinateValue();

            lineLength = getLineLength(x1, y1, x2, y2);
            lineLengthB = getLineLength(x2, y2, x, y);
            lineLengthC = getLineLength(x, y, x1, y1);

            getTriangleAngles();

            _triangleArea = getTriangleArea();

            Figure.FigureArray(tOutput());
        }

        private static void getTriangleAngles()
        {
            _angles[0] = (Math.Pow(lineLength, 2)
                         + Math.Pow(lineLengthC, 2)
                         - Math.Pow(_lineLengthB, 2))
                         / (2 * lineLength * lineLengthC);
            _angles[0] = Math.Round(Math.Acos(_angles[0]) * 57.295, 2, MidpointRounding.AwayFromZero);

            _angles[1] = (Math.Pow(lineLength, 2)
                         + Math.Pow(_lineLengthB, 2)
                         - Math.Pow(lineLengthC, 2))
                         / (2 * lineLength * _lineLengthB);
            _angles[1] = Math.Round(Math.Acos(_angles[1]) * 57.295, 2, MidpointRounding.AwayFromZero);

            _angles[2] = (Math.Pow(_lineLengthB, 2)
                         + Math.Pow(lineLengthC, 2)
                         - Math.Pow(lineLength, 2))
                         / (2 * lineLengthC * _lineLengthB);

            _angles[2] = Math.Round(Math.Acos(_angles[2]) * 57.295, 1, MidpointRounding.AwayFromZero);
        }

        private static double getTriangleArea()
        {
            return 0.5 * lineLength * _lineLengthB * Math.Sin(_angles[1] / 57.295);
        }
        private static string tOutput()
        {
            figureName = "Треугольник";
            return "------------- \n" +
                   $"Фигура: {figureName} \n" +
                   $"Координаты вершины A: x = {x} y = {y} \n" +
                   $"Координаты вершины B: x = {x1} y = {y1} \n" +
                   $"Координаты вершины C: x = {x2} y = {y2} \n" +
                   $"Сторона a: {lineLength} \n" +
                   $"Сторона b: {_lineLengthB} \n" +
                   $"Сторона c: {lineLengthC} \n" +
                   $"Угол a {_angles[2]} \n" +
                   $"Угол b {_angles[0]} \n" +
                   $"Угол y {_angles[1]} \n" +
                   $"Площадь {_triangleArea} \n" +
                   "------------- \n";

        }
    }
    class Square
    {
        private static string _figureName;
        public static string figureName { get { return _figureName; } set { _figureName = value; } }

        private static int[] _centerCoord = new int[2];
        public static int[] centerCoord { get { return _centerCoord; } set { _centerCoord = value; } }

        private static int _aSide;
        private static int _bSide;

        public static int aSide { get { return _aSide; } set { _aSide = value; } }
        public static int bSide { get { return _bSide; } set { _bSide = value; } }

        private static int _squareArea;
        private static int _squarePerimeter;

        public static int squareArea { get { return _squareArea; } set { _squareArea = value; } }
        public static int squarePerimeter { get { return _squarePerimeter; } set { _squarePerimeter = value; } }
        public static void Main()
        {
            Console.WriteLine("введите x: ");
            centerCoord[0] = getCoords();
            Console.WriteLine("введите y: ");
            centerCoord[1] = getCoords();
            Console.WriteLine("введите сторону a");
            aSide = getCoords();
            bSide = aSide;

            squareArea = getArea(aSide, bSide);
            squarePerimeter = getPerimeter(aSide, bSide);

            Figure.FigureArray(sOutput());
        }
        public static int getCoords()
        {
            return UsedFrequently.Try2Parse();
        }
        public static int getArea(int a, int b)
        {
            return a * b;
        }
        public static int getPerimeter(int a, int b)
        {
            return 2*(a + b);
        }
        private static string sOutput()
        {
            figureName = "Квадрат";
            return "------------- \n" +
                   $"Фигура: {figureName} \n" +
                   $"Координаты центра: x = {centerCoord[0]} y = {centerCoord[1]} \n" +
                   $"Сторона a: {aSide} \n" +
                   $"Площадь {squareArea} \n" +
                   $"Периметр {squarePerimeter} \n" +
                   "------------- \n";
        }

    }
    class Rectangle : Square
    {
        public static new void Main()
        {
            Console.WriteLine("введите x: ");
            centerCoord[0] = getCoords();
            Console.WriteLine("введите y: ");
            centerCoord[1] = getCoords();
            Console.WriteLine("введите сторону a");
            aSide = getCoords();
            Console.WriteLine("введите сторону b");
            bSide = getCoords();

            squareArea = getArea(aSide, bSide);
            squarePerimeter = getPerimeter(aSide, bSide);

            Figure.FigureArray(rOutput());
        }
        private static string rOutput()
        {
            figureName = "Прямоугольник";
            return "------------- \n" +
                   $"Фигура: {figureName} \n" +
                   $"Координаты центра: x = {centerCoord[0]} y = {centerCoord[1]} \n" +
                   $"Сторона a: {aSide} \n" +
                   $"Сторона b: {bSide} \n" +
                   $"Площадь {squareArea} \n" +
                   $"Периметр {squarePerimeter} \n" +
                   "------------- \n";
        }
    }
}
