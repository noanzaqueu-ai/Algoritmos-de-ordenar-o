namespace AlgoritmosOrdenacao.Algoritmos;

public static class ShellSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = v[i];
                int j = i;
                while (j >= gap && v[j - gap] > temp)
                {
                    v[j] = v[j - gap];
                    j -= gap;
                }
                v[j] = temp;
            }
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Shell Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
