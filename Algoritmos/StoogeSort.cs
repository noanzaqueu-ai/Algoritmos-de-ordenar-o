namespace AlgoritmosOrdenacao.Algoritmos;

public static class StoogeSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        Stooge(v, 0, v.Length - 1);
        return v;
    }

    private static void Stooge(int[] v, int i, int j)
    {
        if (i >= j) return;
        if (v[i] > v[j])
            (v[i], v[j]) = (v[j], v[i]);
        if (j - i + 1 > 2)
        {
            int t = (j - i + 1) / 3;
            Stooge(v, i, j - t);
            Stooge(v, i + t, j);
            Stooge(v, i, j - t);
        }
    }

    public static void Executar() =>
        Vetores.Exibir("Stooge Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
