namespace ConsoleE
{    public class Program
    {

        public static double AreaOfCircle(double radius)
        { return Math.PI * Math.Pow(radius, 2); }


        public static double AreaOfTriangle(double baseLength, double Height)
        { return 0.5 * baseLength * Height; }

        public static double AreaOfRectangle(double Length, double Width)
        { return Length * Width; }

        public static double SquareArea(double Side)
        { return Math.Pow(Side, 2); }


        static void Main(string[] args)
        {

            Console.Write("Enter the radius of the circle: ");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of the circle is : {AreaOfCircle(circleRadius)}");

            Console.WriteLine("Enter the base of the triangle");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle");
            double Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of the triangle with is {AreaOfTriangle(baseLength, Height)}");

            Console.WriteLine("Enter the lenght of the rectangle");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            double Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of the rectangle is {AreaOfRectangle(Length, Width)}");

            Console.WriteLine("Enter the lenght of the square");
            double Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of the square  is {SquareArea(Side)}");


        }

    }    
         
}