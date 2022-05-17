float real, taxa, cotacao;
real = 5.31f;
taxa = 0f;
Console.WriteLine("Qual a taxa do euro?");
taxa = float.Parse(Console.ReadLine());
cotacao = taxa * real;
Console.WriteLine($"Taxa de cotação convertido para REAL:{cotacao} R$");
//só digitar o valor de 750 que calcula