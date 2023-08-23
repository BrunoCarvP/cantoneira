// See https://aka.ms/new-console-template for more information
using cantoneira;

Console.Write("Entre com um valor inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

int resultado;
CalculoCantoneira calculo = new CalculoCantoneira();
calculo.Cantoneira(num);

Console.WriteLine(calculo);