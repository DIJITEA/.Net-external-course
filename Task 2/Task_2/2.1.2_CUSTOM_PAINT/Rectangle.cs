namespace _2._1._2_CUSTOM_PAINT
{
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
