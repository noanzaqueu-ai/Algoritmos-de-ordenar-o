namespace AlgoritmosOrdenacao.Algoritmos;

public static class OddEvenSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int n = v.Length;
        bool ordenado = false;
        while (!ordenado)
        {
            ordenado = true;
            foreach (int inicio in new[] { 1, 0 }) // fase ímpar, depois par
            {
                for (int i = inicio; i < n - 1; i += 2)
                {
                    if (v[i] > v[i + 1])
                    {
                        (v[i], v[i + 1]) = (v[i + 1], v[i]);
                        ordenado = false;
                    }
                }
            }
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Odd-Even Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
