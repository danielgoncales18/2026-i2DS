using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // comentario de linha
        /*
         comentario de bloco ou
         comentario de varias linhas
        */
       
         // escreve  uma linha de texto na tela 
        Console.WriteLine("programação orientada a objetos\n");

        Console.WriteLine("abstração - 1º pilar da poo");

        /* criar um classe em c# 
           a classe deve ser declarada fora do bloco de programa
        */
        
         /* criar um objeto a partir de uma classe */
           
           pet pet1 = new pet();
           pet pet1 = new pet();
           pet1.nome = "toto";
           pet1.tipo = "cachorro";
           pet1.idade = 3;   
           pet1.mostrarnome();





           pet pet2 = new pet();
           pet2.nome = "mingau";
           pet2.tipo = "gato";
           pet2.idade = 8;
           pet2.mostrarnome();



        }

          




    public class pet  // nome da classe sempre inicial com letras maiusculas 
    {
         // declaração dos atributos 
           public string nome;
           public string tipo;
            public string idade;
           
            // declaração dos metodos
            public void mostrarnome()
         {
            Console.WriteLine("meu nome é " + this.nome);
         }
    

    }
}