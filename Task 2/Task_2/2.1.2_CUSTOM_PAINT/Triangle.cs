namespace _2._1._2_CUSTOM_PAINT
{
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
}
