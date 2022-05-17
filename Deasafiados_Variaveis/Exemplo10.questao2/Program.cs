float real, taxa, cotacao;
real = 0f;
taxa = 0f;
Console.WriteLine("Qual o valor do Real? Exemplo: 5.31");
real = float.Parse(Console.ReadLine());
Console.WriteLine("Qual a taxa do euro?");
taxa = float.Parse(Console.ReadLine());
cotacao = taxa * real;
Console.WriteLine($"Taxa de cotação convertido para REAL:{cotacao} R$");