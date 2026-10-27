namespace AlgoritmosOrdenacao.Algoritmos;

public static class PigeonholeSort
{
    public static int[] Ordenar(int[] entrada)
    {
        if (entrada.Length == 0) return Array.Empty<int>();

        int menor = entrada.Min(), maior = entrada.Max();
        var buracos = new List<int>[maior - menor + 1];
        for (int i = 0; i < buracos.Length; i++) buracos[i] = new List<int>();

        foreach (int x in entrada)
            buracos[x - menor].Add(x);

        return buracos.SelectMany(b => b).ToArray();
    }

    public static void Executar() =>
        Vetores.Exibir("Pigeonhole Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
