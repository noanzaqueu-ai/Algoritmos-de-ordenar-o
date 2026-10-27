namespace AlgoritmosOrdenacao.Algorithms;

public static class PancakeSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        for (int tamanho = v.Length; tamanho > 1; tamanho--)
        {
            int idxMaior = 0;
            for (int i = 1; i < tamanho; i++)
                if (v[i] > v[idxMaior]) idxMaior = i;

            if (idxMaior != tamanho - 1)
            {
                Inverter(v, idxMaior);
                Inverter(v, tamanho - 1);
            }
        }
        return v;
    }

    // Inverte os elementos de 0 até k (inclusive).
    private static void Inverter(int[] v, int k)
    {
        for (int i = 0, j = k; i < j; i++, j--)
            (v[i], v[j]) = (v[j], v[i]);
    }

    public static void Executar() =>
        Vetores.Exibir("Pancake Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
