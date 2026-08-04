internal class Program
{
    private static void Main(string[] args)
    {
     int celsius;
     Console.Write("digite a temperatura em graus celsius:");
     celsius = int.Parse(Console.ReadLine());

     double fahrenheit = (celsius * 9 / 5) + 32;
     
     Console.WriteLine("a temperatura em fahrenheit é: " + fahrenheit);
    }
}