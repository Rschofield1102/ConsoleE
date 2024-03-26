namespace ConsoleE
{    public class Program
    {
        public static int AreaOfCircle(int radius1, int double2)
        {
            var answer1 = radius1 * double2;
            return answer1;
        }


        public static int AreaOfTriangle(double half1, int base1, int height1)
        {

            var answer2 = half1 * base1 * height1;
            return (int)answer2;
        }

        public static int AreaOfRectangle(int Length1, int Height1)
        {
            var answer3 = Length1 * Height1;
            return answer3;
        }

        public static int AreaOfSquare(int Side1, int Double1)
        {
            var answer4 = Side1 * Double1;
            return answer4;
        }


        static void Main(string[] args)
        {
            int answer1 = AreaOfCircle(6, 6);
            Console.WriteLine(answer1);
            int answer2 = AreaOfTriangle(.5, 4, 2);
            Console.WriteLine(answer2);
            int answer3 = AreaOfRectangle(10, 5);
            Console.WriteLine(answer3);
            int answer4 = AreaOfSquare(5, 5);
            Console.WriteLine(answer4);

            //area of circle : 36
            //area of triangle :4
            //area of rectangle :50
            //area of square : 25

            Console.WriteLine($"Hello, what is the area of a circle, with a radius of 6?");
            _ = Console.ReadLine();
            Console.WriteLine($"Okay, what is the area a triangle with the base of 4 and height of 2? o");
            _ = Console.ReadLine();
            Console.WriteLine($"Good!, What is the area of a rectangle with a length of 10 and width of 5?");
            _ = Console.ReadLine();
            Console.WriteLine($"Anddd what is the area of a sqaure with a side of 5?");
            _ = Console.ReadLine();



        }
    }      
}