namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.5m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(1, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            if(isTrue == true && x+y > 1)
            {
                return $"{x + y} dollars";
            }
            else if (isTrue == true && x + y == 1)
            {
                return $"{x + y} dollar";
            }
            else if (isTrue == true && x + y < 1)
            {
                return $"{x + y} dollars";
            }
            else
                return (x + y).ToString();

        }
    }
}
