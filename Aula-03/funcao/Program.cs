internal class Program
{
    private static void Main(string[] args)
    {
        ola("cristiano");
         ola("maria");
    ola("joão");
     
     Console.WriteLine("a soma de 5 e 3 é:" + calcular (5,3,"+"));
     Console.WriteLine("a subtração de 5 e 3 é:" + calcular (5,3,"-"));
     Console.WriteLine("a soma de 5 e 3 é:" + calcular (5,3,"#"));
   
   
    }


    //   public static void ola()
    // {
    //     Console.WriteLine("ola, seja bem vindo!");
    // }
     
     // função com parametro nome e sem retorno
    public static void ola(string nome)
    {
        Console.WriteLine("ola" + nome +"seja bem vindo(a)!");
    }
    
       public static double calcular(double num1, double num2, string operador)
    {
        double resultado=0;

        switch (operador)
        {
            case "+":
                  resultado = num1 + num2;
                  break;        
       
         case "-":
                  resultado = num1 + num2;
                  break;        
       
         case "*":
                  resultado = num1 + num2;
                  break;        
       
         case "/":
                  resultado = num1 + num2;
                  break;        
              default:
              Console.WriteLine("operador informado não é valido.");
              break;
       
        }


        return resultado;
    }

}