string texto;

Console.WriteLine("--- Fluxograma de Engenharia ---");

Console.Write("O objeto está se movendo (S/N)? ");
bool R1 = Console.ReadLine()!.Substring(0,1).ToUpper() == "S";

Console.Write("Deveria? ");
bool R2 = Console.ReadLine()!.Substring(0,1).ToUpper() == "S";

if (R1)
{
    if (R2)
    {
     Console.ForegroundColor = ConsoleColor.DarkGreen 
     texto = ""
    }
}