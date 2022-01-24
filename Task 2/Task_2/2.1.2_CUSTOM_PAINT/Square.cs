using used_frequently;

namespace _2._1._2_CUSTOM_PAINT
{
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
}
