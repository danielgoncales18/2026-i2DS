internal class Program
{ 




    private static void  Main (string[] args)
    {
       Console.WriteLine();
       List<string> frutas  = new List<string>();

       frutas.Add("melancia");
       frutas.Add("banana");
       frutas.Add("maça");
       frutas.Add("abacaxi");
       frutas.Add("pera");
       
       foreach (var item in frutas) 
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("digite o nome da fruta para adicionar");
    
         
        
        foreach (var item in frutas)
        {
             frutas.Add("");
        }
       
    }
}