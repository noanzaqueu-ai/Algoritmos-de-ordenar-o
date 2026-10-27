namespace AlgoritmosOrdenacao.Algorithms;

public static class MergeSort
{
    public static int[] Ordenar(int[] entrada)
    {
        if (entrada.Length <= 1) return (int[])entrada.Clone();

        int meio = entrada.Length / 2;
        int[] esq = Ordenar(entrada[..meio]);
        int[] dir = Ordenar(entrada[meio..]);

        var resultado = new int[entrada.Length];
        int i = 0, j = 0, k = 0;
        while (i < esq.Length && j < dir.Length)
            resultado[k++] = esq[i] <= dir[j] ? esq[i++] : dir[j++];
        while (i < esq.Length) resultado[k++] = esq[i++];
        while (j < dir.Length) resultado[k++] = dir[j++];
        return resultado;
    }

    public static void Executar() =>
        Vetores.Exibir("Merge Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
