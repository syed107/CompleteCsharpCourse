namespace CsharpbasicLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic basic= new Basic(1, "John Doe", "123 Main St");
            basic.Display();
            Console.WriteLine("------------------------------------------");
            Struct @struct = new Struct(2, "Jane Smith", "456 Elm St");
            @struct.Display();
        }
    }
}
