namespace AlgoritmosOrdenacao.Algorithms;

public static class CocktailSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int inicio = 0, fim = v.Length - 1;
        bool trocou = true;
        while (trocou)
        {
            trocou = false;
            for (int i = inicio; i < fim; i++)
            {
                if (v[i] > v[i + 1])
                {
                    (v[i], v[i + 1]) = (v[i + 1], v[i]);
                    trocou = true;
                }
            }
            fim--;
            for (int i = fim; i > inicio; i--)
            {
                if (v[i] < v[i - 1])
                {
                    (v[i], v[i - 1]) = (v[i - 1], v[i]);
                    trocou = true;
                }
            }
            inicio++;
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Cocktail Shaker Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
