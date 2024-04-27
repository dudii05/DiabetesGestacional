using System.Linq.Expressions;
using System.Runtime.InteropServices;

Console.Clear();
int avaliar;
void loop()
{
 
    Console.WriteLine("=== Diabete Gestacional ==\n");
    
    Console.WriteLine("Digite a sua glicose...\n");
    avaliar = Convert.ToInt32(Console.ReadLine());

if(avaliar < 92)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.Write("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose...\n");
    }

if(avaliar < 126 && avaliar >= 92)
{
     Console.ForegroundColor = ConsoleColor.Red;

      Console.Write("Compatível com diabete gestacionail.\n");
}
if(avaliar >= 126)
{
     Console.ForegroundColor = ConsoleColor.Green;

      Console.Write("Diabetes Mellitus na gravidez.\n");
}
Console.ResetColor();

Console.WriteLine("Deseja recomeçar o programa?[S/N]\n");
string resposta = Console.ReadLine()!;

if(resposta.ToUpper() == "S")
{
    Console.ResetColor();
    Console.Clear();
    loop();
}

if(resposta.ToUpper() == "N")
{
    Console.Clear();
}
else
{

}
}
loop();