namespace AlgoritmosOrdenacao.Algoritmos;

public static class BubbleSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool trocou = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (v[j] > v[j + 1])
                {
                    (v[j], v[j + 1]) = (v[j + 1], v[j]);
                    trocou = true;
                }
            }
            if (!trocou) break;
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Bubble Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
