using Shapes;

Circle circle = new Circle("Blue", 3);
Square square = new Square("Red", 5);
Triangle triangle = new Triangle("Green", 2);

List<Shape> shapes = new List<Shape>();
shapes.Add(circle);
shapes.Add(square);
shapes.Add(triangle);

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape);
    Console.WriteLine($"{shape.GetArea():F2}");
}
