namespace AlgoritmosOrdenacao.Algoritmos;

public static class CombSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;
        int gap = n;
        bool trocou = true;
        while (gap > 1 || trocou)
        {
            gap = Math.Max(1, (int)(gap / 1.3));
            trocou = false;
            for (int i = 0; i < n - gap; i++)
            {
                if (v[i] > v[i + gap])
                {
                    (v[i], v[i + gap]) = (v[i + gap], v[i]);
                    trocou = true;
                }
            }
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Comb Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
