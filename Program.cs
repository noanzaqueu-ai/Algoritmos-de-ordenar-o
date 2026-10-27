using AlgoritmosOrdenacao;
using AlgoritmosOrdenacao.Algoritmos;

// Uso:
//   dotnet run                -> executa todos os algoritmos
//   dotnet run -- QuickSort   -> executa apenas o algoritmo informado
var algoritmos = new (string Nome, Action Executar, Func<int[], int[]> Ordenar, int[] Vetor)[]
{
    ("BubbleSort",          BubbleSort.Executar,          BubbleSort.Ordenar,          Vetores.Principal),
    ("SelectionSort",       SelectionSort.Executar,       SelectionSort.Ordenar,       Vetores.Principal),
    ("InsertionSort",       InsertionSort.Executar,       InsertionSort.Ordenar,       Vetores.Principal),
    ("BinaryInsertionSort", BinaryInsertionSort.Executar, BinaryInsertionSort.Ordenar, Vetores.Principal),
    ("ShellSort",           ShellSort.Executar,           ShellSort.Ordenar,           Vetores.Principal),
    ("MergeSort",           MergeSort.Executar,           MergeSort.Ordenar,           Vetores.Principal),
    ("QuickSort",           QuickSort.Executar,           QuickSort.Ordenar,           Vetores.Principal),
    ("HeapSort",            HeapSort.Executar,            HeapSort.Ordenar,            Vetores.Principal),
    ("CountingSort",        CountingSort.Executar,        CountingSort.Ordenar,        Vetores.Principal),
    ("RadixSort",           RadixSort.Executar,           RadixSort.Ordenar,           Vetores.Principal),
    ("BucketSort",          BucketSort.Executar,          v => BucketSort.Ordenar(v),  Vetores.Principal),
    ("CocktailSort",        CocktailSort.Executar,        CocktailSort.Ordenar,        Vetores.Principal),
    ("CombSort",            CombSort.Executar,            CombSort.Ordenar,            Vetores.Principal),
    ("GnomeSort",           GnomeSort.Executar,           GnomeSort.Ordenar,           Vetores.Principal),
    ("OddEvenSort",         OddEvenSort.Executar,         OddEvenSort.Ordenar,         Vetores.Principal),
    ("CycleSort",           CycleSort.Executar,           CycleSort.Ordenar,           Vetores.Principal),
    ("PancakeSort",         PancakeSort.Executar,         PancakeSort.Ordenar,         Vetores.Principal),
    ("StoogeSort",          StoogeSort.Executar,          StoogeSort.Ordenar,          Vetores.Principal),
    ("TimSort",             TimSort.Executar,             TimSort.Ordenar,             Vetores.Principal),
    ("TreeSort",            TreeSort.Executar,            TreeSort.Ordenar,            Vetores.Principal),
    ("PigeonholeSort",      PigeonholeSort.Executar,      PigeonholeSort.Ordenar,      Vetores.Principal),
    ("BogoSort",            BogoSort.Executar,            BogoSort.Ordenar,            Vetores.Pequeno),
};

var escolhidos = args.Length > 0
    ? algoritmos.Where(a => args.Contains(a.Nome, StringComparer.OrdinalIgnoreCase)).ToArray()
    : algoritmos;

if (escolhidos.Length == 0)
{
    Console.WriteLine("Algoritmo não encontrado. Opções: " + string.Join(", ", algoritmos.Select(a => a.Nome)));
    return 1;
}

int falhas = 0;
foreach (var (nome, executar, ordenar, vetor) in escolhidos)
{
    executar();

    var esperado = (int[])vetor.Clone();
    Array.Sort(esperado);
    bool ok = ordenar(vetor).SequenceEqual(esperado);
    Console.WriteLine(ok ? "Resultado: OK" : $"Resultado: FALHOU ({nome})");
    Console.WriteLine();
    if (!ok) falhas++;
}

Console.WriteLine(falhas == 0
    ? $"Todos os {escolhidos.Length} algoritmo(s) ordenaram corretamente."
    : $"{falhas} algoritmo(s) falharam.");
return falhas == 0 ? 0 : 1;
