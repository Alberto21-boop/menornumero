namespace menornumero;

public class Program
{
    static void Main(string[] args)
    {

        //Fazer um programa para ler três números interiso. Em seguida mostrar qual o menor dentre os três
        //numeros lidos.Em caso de empate, mostrar apenas uma vez.

        int A, B, C, Menor;

        Console.WriteLine("Entre com um numero inteiro por favor.");
        Console.Write("Primeiro numero = ");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Agora entre com o segundo numero por favor.");
        Console.Write("Segundo numero = ");
        B = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Agora entre com um terceiro numero por favor.");
        Console.Write("Terceiro numero = ");
        C = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if(A < B && A < C)
        {
            Menor = A;
            Console.WriteLine("Menor numero digitado = " + A);
        }
        else if(B < A && B < C)
        {
            Menor = B;
            Console.WriteLine("Menor numero digitado = " + B);
        }
        else
        {
            Menor = C;
            Console.WriteLine("Menor numero digitado = " + C);

        }

    }
}