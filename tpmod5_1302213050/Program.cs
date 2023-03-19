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
        DataGeneric<long> objData = new DataGeneric<long>(1302213050);
        objData.printData();
    }
}

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T inputAngka)
        {
            data = inputAngka;
        }

        public void printData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }



