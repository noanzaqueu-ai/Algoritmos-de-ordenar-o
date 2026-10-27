namespace AlgoritmosOrdenacao.Algorithms;

public static class SelectionSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int menor = i;
            for (int j = i + 1; j < n; j++)
                if (v[j] < v[menor]) menor = j;
            (v[i], v[menor]) = (v[menor], v[i]);
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Selection Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
