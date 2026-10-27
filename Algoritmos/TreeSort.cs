namespace AlgoritmosOrdenacao.Algoritmos;

public static class TreeSort
{
    private sealed class No
    {
        public int Valor;
        public No? Esq, Dir;
        public No(int valor) => Valor = valor;
    }

    public static int[] Ordenar(int[] entrada)
    {
        No? raiz = null;
        foreach (int x in entrada)
            raiz = Inserir(raiz, x);

        var saida = new List<int>(entrada.Length);
        EmOrdem(raiz, saida);
        return saida.ToArray();
    }

    private static No Inserir(No? raiz, int valor)
    {
        if (raiz is null) return new No(valor);
        if (valor < raiz.Valor) raiz.Esq = Inserir(raiz.Esq, valor);
        else raiz.Dir = Inserir(raiz.Dir, valor);
        return raiz;
    }

    private static void EmOrdem(No? raiz, List<int> saida)
    {
        if (raiz is null) return;
        EmOrdem(raiz.Esq, saida);
        saida.Add(raiz.Valor);
        EmOrdem(raiz.Dir, saida);
    }

    public static void Executar() =>
        Vetores.Exibir("Tree Sort (BST)", Vetores.Principal, Ordenar(Vetores.Principal));
}
