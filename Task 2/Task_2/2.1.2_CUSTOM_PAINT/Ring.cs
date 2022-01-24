namespace _2._1._2_CUSTOM_PAINT
{
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
}
