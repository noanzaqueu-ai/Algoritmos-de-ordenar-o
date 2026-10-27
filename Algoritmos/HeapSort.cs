namespace AlgoritmosOrdenacao.Algoritmos;

public static class HeapSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(v, n, i);
        for (int i = n - 1; i > 0; i--)
        {
            (v[0], v[i]) = (v[i], v[0]);
            Heapify(v, i, 0);
        }
        return v;
    }

    private static void Heapify(int[] v, int n, int i)
    {
        int maior = i;
        int esq = 2 * i + 1, dir = 2 * i + 2;
        if (esq < n && v[esq] > v[maior]) maior = esq;
        if (dir < n && v[dir] > v[maior]) maior = dir;
        if (maior != i)
        {
            (v[i], v[maior]) = (v[maior], v[i]);
            Heapify(v, n, maior);
        }
    }

    public static void Executar() =>
        Vetores.Exibir("Heap Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
