namespace AlgoritmosOrdenacao.Algorithms;

public static class CycleSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;
        for (int inicio = 0; inicio < n - 1; inicio++)
        {
            int item = v[inicio];
            int pos = inicio;
            for (int i = inicio + 1; i < n; i++)
                if (v[i] < item) pos++;

            if (pos == inicio) continue;

            while (item == v[pos]) pos++;
            (v[pos], item) = (item, v[pos]);

            while (pos != inicio)
            {
                pos = inicio;
                for (int i = inicio + 1; i < n; i++)
                    if (v[i] < item) pos++;

                while (item == v[pos]) pos++;
                (v[pos], item) = (item, v[pos]);
            }
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Cycle Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
