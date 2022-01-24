using used_frequently;

namespace _2._1._2_CUSTOM_PAINT
{
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
}
