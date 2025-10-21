// See https://aka.ms/new-console-template for more information
int start, end;
Console.WriteLine("Digite o numero inicial da tabuada (start)");
start = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero final da tabuada (end)");
end = int.Parse(Console.ReadLine());

for  (int i = start; i <= end; i++)
{
    Console.WriteLine($"Tabuada do {i} :");
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    
}
Console.WriteLine("Fim da tabuada");