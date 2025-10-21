int voto;
int candidatoA = 0, candidatoB = 0, candidatoC = 0, nulos = 0;
Console.WriteLine("Seja Bem-vindo ao sistema de votação!");
Console.WriteLine("1 - Candidato A");
Console.WriteLine("2 - Candidato B");
Console.WriteLine("3 - Candidato C");
Console.WriteLine("9 - Nulos");
Console.WriteLine("0 - Encerrar votação");

while (true)
{
    Console.WriteLine("Digite o seu voto");
    voto = int.Parse(Console.ReadLine());
    if (voto == 0)
      break; 
    switch(voto)
    {
        case 1:
            candidatoA++;
            break;
        case 2:
            candidatoB++;
            break;
        case 3:
            candidatoC++;
            break;
        case 9:
            nulos++;
            break;
        default:
            Console.WriteLine("Voto invalido!");
            break;

    }
}
Console.WriteLine("\nResultado da Votação");
Console.WriteLine($"Candidato A: {candidatoA} votos:");
Console.WriteLine($"Candidato B: {candidatoB} votos:");
Console.WriteLine($"Candidato C: {candidatoC} votos:");
Console.WriteLine($"Nulos: {nulos} votos:");