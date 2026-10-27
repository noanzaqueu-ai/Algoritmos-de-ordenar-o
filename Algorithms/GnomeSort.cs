namespace AlgoritmosOrdenacao.Algorithms;

public static class GnomeSort
{
    public static int[] Ordenar(int[] entrada)
    {
        var v = (int[])entrada.Clone();
        int i = 0;
        while (i < v.Length)
        {
            if (i == 0 || v[i] >= v[i - 1])
            {
                i++;
            }
            else
            {
                (v[i], v[i - 1]) = (v[i - 1], v[i]);
                i--;
            }
        }
        return v;
    }

    public static void Executar() =>
        Vetores.Exibir("Gnome Sort", Vetores.Principal, Ordenar(Vetores.Principal));
}
