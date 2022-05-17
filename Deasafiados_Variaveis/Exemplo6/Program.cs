float alturaHomem, pesoIdeal;
alturaHomem = 0f;
pesoIdeal = 0f;
Console.WriteLine("Digite a altura do Homem: Ex: 1.77");
alturaHomem = float.Parse(Console.ReadLine());
pesoIdeal = (72.7f * alturaHomem) - 58f;
Console.WriteLine("O seu peso ideal é:" + pesoIdeal.ToString("F2"));
