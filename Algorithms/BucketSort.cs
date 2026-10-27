namespace AlgoritmosOrdenacao.Algorithms;

public static class BucketSort
{
    public static int[] Ordenar(int[] entrada, int qtdBaldes = 5)
    {
        if (entrada.Length == 0) return Array.Empty<int>();

        int menor = entrada.Min(), maior = entrada.Max();
        if (menor == maior) return (int[])entrada.Clone();

        double tamanho = (double)(maior - menor) / qtdBaldes;
        var baldes = new List<int>[qtdBaldes];
        for (int i = 0; i < qtdBaldes; i++) baldes[i] = new List<int>();

        foreach (int x in entrada)
        {
            int idx = Math.Min((int)((x - menor) / tamanho), qtdBaldes - 1);
            baldes[idx].Add(x);
        }

        var resultado = new List<int>(entrada.Length);
        foreach (var balde in baldes)
        {
            // ordena cada balde com insertion sort
            for (int i = 1; i < balde.Count; i++)
            {
                int chave = balde[i];
                int j = i - 1;
                while (j >= 0 && balde[j] > chave)
                {
                    balde[j + 1] = balde[j];
                    j--;
                }
                balde[j + 1] = chave;
            }
            resultado.AddRange(balde);
        }
        return resultado.ToArray();
    }

    public static void Executar() =>
        Vetores.Exibir("Bucket Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
