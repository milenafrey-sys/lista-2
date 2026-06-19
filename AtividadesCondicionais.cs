public static class AtividadesCondicionais
{
    public static void Atividade01()
    {
        Console.Write("Informe a idade do visitante: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 16)
{
    Console.WriteLine("Entrada liberada.");
}
else
{
    Console.WriteLine("Entrada permitida somente com responsável.");
}
    }

    public static void Atividade02()
    {
Console.Write ("Informe a idade do visitante:");
int idade = int.Parse(Console.ReadLine());
Console.Write("Informe a nota final: ");
double nota = double.Parse(Console.ReadLine());

if (idade >= 16)
if (nota >= 7)
{
    Console.WriteLine("Entrada liberada.");
    Console.WriteLine("Estudante aprovado.");
}
else if (nota >= 5)
{
    Console.WriteLine("Estudante em recuperação.");
}
else
{
    Console.WriteLine("Entrada permitida somente com responsável.");
    Console.WriteLine("Estudante reprovado.");
}
    }

    public static void Atividade03()
    {
 Console.Write("Classificação de temperatura ambiente:")
    }
  

