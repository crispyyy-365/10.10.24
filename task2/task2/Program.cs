namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());    
            int c = Convert.ToInt32(Console.ReadLine());
        }
        public static void Area(int r)
        {
            int p = 3;

            Console.WriteLine("dairenin sahesi " + p * r * r);
        }
        public static void Area(int a, int b)
        {
            Console.WriteLine("duzbucaqlinin sahesi " + a * b);
        }
        public static void Area(int a, int b, int c)
        {
            Console.WriteLine("duzbucaqli paralelepipedin tam sethinin sahesi " + 2 * (a * b + a * c + b * c));
        }
        public static void Area(double a, double b, double c)
        {
            Console.WriteLine("p = " + (a + b + c) / 2);
        }
    }
}