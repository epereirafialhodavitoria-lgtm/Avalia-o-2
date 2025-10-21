string[] nomes = { "Ana", "Eduarda", "Alice", "Julia", "Bruno" };

Console.WriteLine("Digite um nome para pesquisa");
string nomeBusca = Console.ReadLine();
bool encontrado  = false;

foreach (string nome in nomes)
{
    if (nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
    {
        encontrado = true;
        break;
    }
       
}
if (encontrado)
{
    Console.WriteLine($"Nome'{nomeBusca}' foi encontrado no vetor");
}
else
{
    Console.WriteLine($"Nome '{nomeBusca}' não foi encontrado no vetor" );
}