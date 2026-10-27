namespace AlgoritmosOrdenacao.Algorithms;

public static class BinaryInsertionSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        for (int i = 1; i < v.Length; i++)
        {
            int chave = v[i];
            int esq = 0, dir = i;
            while (esq < dir)
            {
                int meio = (esq + dir) / 2;
                if (v[meio] <= chave) esq = meio + 1;
                else dir = meio;
            }
            for (int j = i; j > esq; j--)
                v[j] = v[j - 1];
            v[esq] = chave;
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Binary Insertion Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
