// See https://aka.ms/new-console-template for more information
internal class Program
{
    public class HaloGeneric
    {
        public static void sapaUser<T>(T input)
        {
            Console.WriteLine("Halo User " + input);
        }
    }
    public static void Main(string[] args)
    {
        HaloGeneric.sapaUser("Yoga");
    }
}