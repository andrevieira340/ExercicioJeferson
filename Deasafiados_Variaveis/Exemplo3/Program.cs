float comissaoBonusVenda, valorVendidoEmMaio, comissaoCalc;
comissaoBonusVenda = 0.05f;
valorVendidoEmMaio = 500.000f;
comissaoCalc = comissaoBonusVenda * valorVendidoEmMaio;
Console.WriteLine($"Valor de comissão recebido: {comissaoCalc.ToString("F3")}");