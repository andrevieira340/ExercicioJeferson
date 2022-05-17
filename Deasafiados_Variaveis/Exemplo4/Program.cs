float fahrenheit = 0f;
float celsius = 0f;
Console.WriteLine("Entre com a temperatura(em valor numérico) de Celsius:");
celsius = float.Parse(Console.ReadLine());
fahrenheit = (9 * celsius + 160) / 5;
Console.WriteLine($"O valor convertido de Celsius para fahrenheit: {fahrenheit}");