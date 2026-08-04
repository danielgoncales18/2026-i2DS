using System.Collections.Specialized;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        /* vetores e matrizes 
           vetor => é uma estrutura de dados utilizados para armazenar
           varios valores de um mesmo tipo dentro de uma unica variavel

           sintaxe: tipo[] nome_vetor = new tipo[tamanho];         
        */
            
        /* iniciar um vetor -> lista de frutas */
                           
        string[] listafrutas = {"maça","manga","morango","melancia","melão"};

        Console.WriteLine("acessar o terceiro elemento da lista");
        Console.WriteLine(listafrutas[2]);

        Console.WriteLine("alterar o segundo elemento da lista:");
        listafrutas[1] = "banana";

        for (int indice = 0; indice < listafrutas.Length; indice++)
        {
            Console.WriteLine(listafrutas[indice]);
        }
        
        /*************************************************************************/
        foreach (string fruta in listafrutas)
        {
            Console.WriteLine(fruta);
        }
           
    }
}