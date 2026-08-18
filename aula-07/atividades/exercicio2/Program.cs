internal class Program
{
    public class Aluno
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? idade  {get; set;}
    }

    private static void Main(string[] args)
    {
        

       
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno{ 
            Id = 1, Nome = "Zuleika", idade = "31"};
        Aluno aluno2 = new Aluno{ 
            Id = 2, Nome = "Pafúncio", idade = "25"};
        Aluno aluno3 = new Aluno{ 
            Id = 3, Nome = "Asdrúbal", idade = "45"};
          Aluno aluno4 = new Aluno{ 
            Id = 3, Nome = "marcos", idade = "75"};
             Aluno aluno5 = new Aluno{ 
            Id = 3, Nome = "gustavo", idade = "65"};
       
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2); 
        listaAlunos.Add(aluno3);
        listaAlunos.Add(aluno4);
        listaAlunos.Add(aluno5);
           
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.idade}");
        }

       

        // 5 - Quantidade de elementos da lista
        Console.WriteLine();
        Console.WriteLine($"Quantidade de Elementos na lista: {listaAlunos.Count()}");

        // 6 - Remover um elemento da lista por índice
        listaAlunos.RemoveAt(0);
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.idade}");
        }

       
        

       
    }
}