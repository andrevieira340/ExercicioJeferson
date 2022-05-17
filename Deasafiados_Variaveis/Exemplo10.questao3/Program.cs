float comissaoBonusVenda, valorVendidoEmMaio, comissaoCalc;
Console.WriteLine("Qual o valor da comissão de Venda? Exemplo 0.05 equivale a 5%");
comissaoBonusVenda = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor que o vendedor de carro, vendeu no mês? Exemplo: 500.000 equivale a 500mil");
valorVendidoEmMaio = float.Parse(Console.ReadLine());
comissaoCalc = comissaoBonusVenda * valorVendidoEmMaio;
Console.WriteLine($"Valor de comissão recebido: {comissaoCalc.ToString("F3")}");
