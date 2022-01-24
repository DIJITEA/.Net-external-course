using used_frequently;

namespace _2._1._2_CUSTOM_PAINT
{
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
}
