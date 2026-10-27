namespace AlgoritmosOrdenacao.Algoritmos;

public static class CountingSort
{
    public static int[] Ordenar(int[] entrada)
    {
        if (entrada.Length == 0) return Array.Empty<int>();

        int menor = entrada.Min(), maior = entrada.Max();
        var contagem = new int[maior - menor + 1];
        foreach (int x in entrada)
            contagem[x - menor]++;

        var resultado = new int[entrada.Length];
        int k = 0;
        for (int i = 0; i < contagem.Length; i++)
            for (int c = 0; c < contagem[i]; c++)
                resultado[k++] = i + menor;
        return resultado;
    }

    public static void Executar() =>
        Vetores.Exibir("Counting Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
