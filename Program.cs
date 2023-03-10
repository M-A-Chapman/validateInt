namespace validateInt;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an Integer:");
        var value = Console.ReadLine();
        var response = (0 < Convert.ToInt32(value) && Convert.ToInt32(value) < 11) ? "Valid" : "Invalid";
        Console.WriteLine(response);
    }
}
