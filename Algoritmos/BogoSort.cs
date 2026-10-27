namespace AlgoritmosOrdenacao.Algoritmos;

public static class BogoSort
{
    private static readonly Random Aleatorio = new();

    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        while (!Ordenado(v))
            Embaralhar(v);
        return v;
    }

    private static bool Ordenado(int[] v)
    {
        for (int i = 0; i < v.Length - 1; i++)
            if (v[i] > v[i + 1]) return false;
        return true;
    }

    private static void Embaralhar(int[] v)
    {
        for (int i = v.Length - 1; i > 0; i--)
        {
            int j = Aleatorio.Next(i + 1);
            (v[i], v[j]) = (v[j], v[i]);
        }
    }

    // Usa o vetor pequeno: com muitos elementos levaria uma eternidade.
    public static void Executar() =>
        Vetores.Exibir("Bogo Sort", Vetores.Pequeno, Ordenar(Vetores.Pequeno));
}
