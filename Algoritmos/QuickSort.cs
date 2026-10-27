namespace AlgoritmosOrdenacao.Algoritmos;

public static class QuickSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        Qs(v, 0, v.Length - 1);
        return v;
    }

    private static void Qs(int[] v, int baixo, int alto)
    {
        if (baixo >= alto) return;

        int pivo = v[alto];
        int i = baixo - 1;
        for (int j = baixo; j < alto; j++)
        {
            if (v[j] <= pivo)
            {
                i++;
                (v[i], v[j]) = (v[j], v[i]);
            }
        }
        (v[i + 1], v[alto]) = (v[alto], v[i + 1]);
        int p = i + 1;
        Qs(v, baixo, p - 1);
        Qs(v, p + 1, alto);
    }

    public static void Executar() =>
        Vetores.Exibir("Quick Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
