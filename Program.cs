internal class Area {


    public Area()
    {
        double baseLength, height, area;

        Console.WriteLine("A simple interactive Program to calculate the area of a triangle\n");

        Console.Write("enter the base of the triangle: ");
        baseLength = Double.Parse(Console.ReadLine());
        Console.Write("enter the height of the triangle: ");
        height = Double.Parse(Console.ReadLine());

        area = height * baseLength / 2;
        Console.WriteLine($"The area of a triangle with baseLength {baseLength} and height {height} is { area}");

    }
    public static void Main(String[] args) {
        Area areaData = new Area();


    }

}
