namespace Generic_Test_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC1 maxInt = new UC1();
            int IntVal = maxInt.maximumValue(54, 6, 90);
            Console.WriteLine("The Maximum Float Value is: " + maxInt);

            UC2 maxFloat = new UC2();
            float floatValue = maxFloat.maximumValue(54.54f, 65.87f, 97.21f);
            Console.WriteLine("The Maximum Float Value is: " + floatValue);

        }
    }
}