namespace PeselValidator;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Please provide a PESEL: ");
            var peselWannabe = Console.ReadLine();

            Console.WriteLine($"Hello, World! {peselWannabe}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}