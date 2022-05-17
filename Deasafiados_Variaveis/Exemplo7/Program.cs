Console.WriteLine("Qual a 1 nota do aluno ?");
int alunoNota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a 2 nota do aluno ?");
int alunoNota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a 3 nota do aluno ?");
int alunoNota3 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a 4 nota do aluno ?");
int alunoNota4 = int.Parse(Console.ReadLine());
int notaTotal = 0;
int media = 7;
int pontoDadoPeloProf = 1;
notaTotal = alunoNota1 + alunoNota2 + alunoNota3 + alunoNota4;
notaTotal = notaTotal / 4;
notaTotal += pontoDadoPeloProf;
Console.WriteLine("Média do Aluno :" + notaTotal);
if (notaTotal < 7)
{
    Console.WriteLine("O aluno está reprovado!");
}
else if (notaTotal >= 7)
{
    Console.WriteLine("O aluno está aprovado!");
}