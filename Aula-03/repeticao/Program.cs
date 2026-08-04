internal class Program
{
    private static void Main(string[] args)
    {
       /* 
          sintaxe:
            enquanto uma condição for verdadeira
            execute um conjunto de comandos 

        for -> quando sabemos a quantidade de repetições.
        while -> quando a repetição depende de uma condição.
        do...while -> quando precisa execultar ao menos uma vez o bloco de codigo
       */

       /* laco for: imprimir numeros de 1 até 10*/

       Console.WriteLine("imprimir numeros de 1 até 10, ultilizandoo laco for.");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }  
    
    
    /* laco for: contagem regressiva de 10 até 0*/

       Console.WriteLine("imprimir contagem regressiva.");
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }  
    
          /*********************************************************************/    
      
          
          Console.WriteLine("imprimir numeros de 1 até 10, ultilizandoo laco while.");

          int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;

        }

        /* solicitar a senha ate acertar*/

        string senha = "";

     while(senha != "2444")
        {
            Console.Write("digite a senha:");

            senha = Console.ReadLine();
        }

        Console.WriteLine("acesso permitido!");

         /***************************************************************************************/
         int num;
        do
        {
            Console.WriteLine("digite um numero positivo:");
            num = int.Parse(Console.ReadLine());
        }while(num <=0);


    }
}