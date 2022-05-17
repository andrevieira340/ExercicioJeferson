int A, B;
Console.WriteLine("Qual o valor de A?");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor de B?");
B = int.Parse(Console.ReadLine());
int valorRecebido = A - B;
if (valorRecebido < 0)
{
    Console.WriteLine("Total Negativo: " + valorRecebido);
}
else
{
    Console.WriteLine("Total Positivo: " + valorRecebido);
}