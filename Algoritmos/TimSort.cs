namespace AlgoritmosOrdenacao.Algoritmos;

// Versão simplificada: insertion sort em "runs" fixos + merge bottom-up.
public static class TimSort
{
    private const int Run = 4;

    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;

        for (int i = 0; i < n; i += Run)
            Insertion(v, i, Math.Min(i + Run - 1, n - 1));

        for (int tam = Run; tam < n; tam *= 2)
        {
            for (int esq = 0; esq < n; esq += 2 * tam)
            {
                int meio = esq + tam - 1;
                int dir = Math.Min(esq + 2 * tam - 1, n - 1);
                if (meio < dir)
                    Merge(v, esq, meio, dir);
            }
        }
        return v;
    }

    private static void Insertion(int[] v, int esq, int dir)
    {
        for (int i = esq + 1; i <= dir; i++)
        {
            int chave = v[i];
            int j = i - 1;
            while (j >= esq && v[j] > chave)
            {
                v[j + 1] = v[j];
                j--;
            }
            v[j + 1] = chave;
        }
    }

    private static void Merge(int[] v, int esq, int meio, int dir)
    {
        int[] a = v[esq..(meio + 1)];
        int[] b = v[(meio + 1)..(dir + 1)];
        int i = 0, j = 0, k = esq;
        while (i < a.Length && j < b.Length)
            v[k++] = a[i] <= b[j] ? a[i++] : b[j++];
        while (i < a.Length) v[k++] = a[i++];
        while (j < b.Length) v[k++] = b[j++];
    }

    public static void Executar() =>
        Vetores.Exibir("Tim Sort (simplificado)", Vetores.Principal, Ordenar(Vetores.Principal));
}
