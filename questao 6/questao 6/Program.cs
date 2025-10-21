// See https://aka.ms/new-console-template for more information
double nota1, nota2, nota3, peso1, peso2, peso3, media;
peso1 = 1; peso2 = 2; peso3 = 3; 
    
Console.WriteLine("olá digite a sua primeira nota:" );
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("olá digite a sua segunda nota:");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("olá digite a sua terceira nota:");
nota3 = double.Parse(Console.ReadLine());

media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
Console.WriteLine($"media: {media:f2}");

if (media >= 7)
    Console.WriteLine("Aprovado");

else if (media >= 5)
    Console.WriteLine("Recuperação");

else
    Console.WriteLine("Reprovado");
