namespace AlgoritmosOrdenacao.Algoritmos;

public static class RadixSort
{
    // LSD Radix Sort em base 10, com suporte a números negativos.
    public static int[] Ordenar(int[] entrada)
    {
        if (entrada.Length == 0) return Array.Empty<int>();

        int menor = entrada.Min();
        long deslocamento = menor < 0 ? -(long)menor : 0;
        var v = entrada.Select(x => x + deslocamento).ToArray();

        long maximo = v.Max();
        for (long exp = 1; maximo / exp > 0; exp *= 10)
        {
            var baldes = new List<long>[10];
            for (int i = 0; i < 10; i++) baldes[i] = new List<long>();
            foreach (long x in v)
                baldes[(int)((x / exp) % 10)].Add(x);
            v = baldes.SelectMany(b => b).ToArray();
        }
        return v.Select(x => (int)(x - deslocamento)).ToArray();
    }

    public static void Executar() =>
        Vetores.Exibir("Radix Sort (LSD)", Vetores.Principal, Ordenar(Vetores.Principal));
}
