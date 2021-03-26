using System;

public class Comparandoswitch
{
    static void Main(string[] args)
    {
        int idade = 16;
        switch (idade)
        {
            case 15:
                Console.WriteLine("SUB -15");
                break;
            case 16:
                Console.WriteLine("SUB-17");
                break;
            case 17:
                Console.WriteLine("SUB-17");
                break;
            case 18:
                Console.WriteLine("SUB-20");
                break;
            default:
                Console.WriteLine("Categoria não definida");
                break;

        }
        Console.Read();
    }

}    

        
    