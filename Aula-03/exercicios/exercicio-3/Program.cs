internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o nome do aluno: ");
        
        
        string nome = Console.ReadLine();
   
   
        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota3 = Convert.ToDouble(Console.ReadLine());
   
         static double CalcularMedia(double n1, double n2, double n3)
{
           return (n1 + n2 + n3) / 3;
}
  







    }
}