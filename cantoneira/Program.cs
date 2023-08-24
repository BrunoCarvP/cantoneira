// See https://aka.ms/new-console-template for more information
using cantoneira;



Console.Write("Entre com um valor inteiro: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

CalculoCantoneira calculo = new CalculoCantoneira();
List<string> valor = calculo.Cantoneira(n);

foreach (string list in valor)
{
    Console.WriteLine(list);
}

