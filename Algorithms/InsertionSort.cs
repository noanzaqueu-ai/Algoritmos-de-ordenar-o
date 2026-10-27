namespace AlgoritmosOrdenacao.Algorithms;

public static class InsertionSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        for (int i = 1; i < v.Length; i++)
        {
            int chave = v[i];
            int j = i - 1;
            while (j >= 0 && v[j] > chave)
            {
                v[j + 1] = v[j];
                j--;
            }
            v[j + 1] = chave;
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Insertion Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
