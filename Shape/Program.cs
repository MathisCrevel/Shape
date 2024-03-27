using Shape;

class Programm 
{
    static void Main(String[] args)
    {   
    Form[] formes = { new Rectangle(1, 2), new Circle(3), new Triangle(4, 2) };
    AreaCalculator areaCalculator = new AreaCalculator();
    Form[] square = { new Square(2), };
    Console.WriteLine(areaCalculator.TotalArea(formes));
    Console.WriteLine(areaCalculator.TotalArea(square));
    }
}

