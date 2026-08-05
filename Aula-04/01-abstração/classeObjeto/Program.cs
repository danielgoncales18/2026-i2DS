using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
          classe -> é a abstração de um objeto do mundo real para o mundo computacional.
          objeto -> é a instancia de uma classe
        */


          // instanciar um objeto do tipo aluno
          Aluno aluno01 = new Aluno();
          Aluno aluno02 = new Aluno();

          aluno01.Nome = "josé da silve";
          aluno01.RM = 2444;
          aluno01.Datanascimento = new DateOnly(2010,01,15);


          aluno02.Nome = "joão dos sasntos";
          aluno02.RM = 2444;
          aluno02.Datanascimento = new DateOnly(2006,12,07);

          // execultar os metodos
          aluno01.Apresentarse();
          aluno02.Apresentarse();



 }

        public class Aluno // declaração de uma classe
    {
        // atributos -> caracteristicas
        public string Nome { get; set; } = string.Empty;
        public int RM { get; set; }

        public DateOnly Datanascimento { get; set; }


        // metodos -> ações ou funcionalidades
        public void Apresentarse()
        {
            Console.WriteLine($"olá, meu nome é {Nome}, Meu RM é {RM}, nasci na Data {Datanascimento}");
        }

    
    }



}


