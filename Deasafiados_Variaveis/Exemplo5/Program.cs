float fahrenheit = 0f;
float celsius = 0f;
Console.WriteLine("Entre com a temperatura(em valor numérico) de Fahrenheit:");
fahrenheit = float.Parse(Console.ReadLine());
celsius = (fahrenheit - 32) * 5 / 9;
Console.WriteLine($"O valor convertido de Fahrenheit para Celsius: {celsius}");
//nota aqui na questão 5 apenas inverti e coloquei a formula kk