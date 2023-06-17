Console.Clear();

int numeroADD = -1;
string entrada;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(" ==== ENTRADA VÁLIDA ====   \n");
Console.ResetColor();

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Digite de 1 a 9 ou então 0 para cancelar: ");
    entrada = Console.ReadLine()!;
    Console.ResetColor();

    if (int.TryParse(entrada, out numeroADD))
    {
        if (numeroADD < 0 || numeroADD > 9)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEntrada inválida. Digite um número entre 1 e 9 ou 0 para cancelar.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEntrada inválida. Utilize apenas números.");
        Console.ResetColor();
        return;
    }
    
} while (numeroADD < 0 || numeroADD > 9);

if (numeroADD == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nOperação cancelada.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"\nNúmero selecionado = {numeroADD}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\n\nVolte Sempre :)");
    Console.ResetColor();
}
