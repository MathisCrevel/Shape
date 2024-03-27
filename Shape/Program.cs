using Shape;

class Programm 
{
    static void Main(String[] args)
    {   
    object[] formes = { new Rectangle(1, 2), new Circle(3), new Triangle(4, 2) };
    AreaCalculator areaCalculator = new AreaCalculator();
    Console.WriteLine(areaCalculator.TotalArea(formes));
    }
}

