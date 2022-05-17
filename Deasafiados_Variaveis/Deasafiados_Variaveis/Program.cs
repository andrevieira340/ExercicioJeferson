// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

byte value = 10;
byte value1 = 20;
int total;


 int GetTotal() {
 return value + value1;
}


total = value - value1;

Console.WriteLine($"o valor total é: {total}");

*/

/////////////////////////////////////////////////////////////////
///
/*
float fahrenheit = 0f;
float celsius = 0f;

Console.WriteLine("Entre com a temperatura(em valor numérico) de Celsius:");
celsius = float.Parse(Console.ReadLine());

fahrenheit = (9 * celsius + 160) / 5;

Console.WriteLine($"O valor convertido de Celsius para fahrenheit: {fahrenheit}");
*/
/*
int[] notas = new int[3];
notas[0] = 2;
notas[1] = 3;
notas[2] = 5;
notas[3] = 2;
*/
//int[] notas = new int[] { 2, 4, 1, 2 };
/*
aluno1 = 20;
aluno2 = 24;
aluno3 = 50;
aluno4 = 31;
*/
float comissaoBonusVenda, valorVendidoEmMaio, comissaoCalc;

Console.WriteLine("Qual o valor da comissão de Venda? Exemplo 0.05 equivale a 5%");
comissaoBonusVenda = float.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor que o vendedor de carro, vendeu no mês? Exemplo: 500.000 equivale a 500mil");
valorVendidoEmMaio = float.Parse(Console.ReadLine());

comissaoCalc = comissaoBonusVenda * valorVendidoEmMaio;

Console.WriteLine($"Valor de comissão recebido: {comissaoCalc.ToString("F3")}");



















//Console.WriteLine(valorVendidoEmMaio.ToString("F3"));
//vendedor de carro vendeu 500mil

