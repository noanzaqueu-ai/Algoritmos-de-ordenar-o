namespace AlgoritmosOrdenacao;

/// <summary>
/// Vetores externos compartilhados por todos os algoritmos.
/// Altere aqui para testar com outros dados.
/// </summary>
public static class Vetores
{
    public static readonly int[] Principal = { 64, 34, 25, 12, 22, 11, 90, 5, -3, 25, 0, 47 };

    // Usado apenas pelo Bogo Sort (com 12 elementos seria inviável).
    public static readonly int[] Pequeno = { 5, 2, 4, 1, 3 };

    public static void Exibir(string nome, int[] original, int[] ordenado)
    {
        Console.WriteLine($"=== {nome} ===");
        Console.WriteLine($"Vetor original: [{string.Join(", ", original)}]");
        Console.WriteLine($"Vetor ordenado: [{string.Join(", ", ordenado)}]");
    }
}
