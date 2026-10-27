# Sorting Algorithms in C#

22 sorting algorithms, each in its own file (`Algorithms/`), using a shared external array
(`Vetores.cs`). When run, each algorithm prints the **original array** and the **sorted array**,
and the result is checked against `Array.Sort`.

## How to run

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet run                    # runs all algorithms
dotnet run -- QuickSort       # runs a single one (use the class name)
```

## Test array

Edit `Vetores.cs` to try other data:

```csharp
public static readonly int[] Principal = { 64, 34, 25, 12, 22, 11, 90, 5, -3, 25, 0, 47 };
public static readonly int[] Pequeno   = { 5, 2, 4, 1, 3 }; // used only by Bogo Sort
```

## Algorithms

| Category | Algorithms |
|---|---|
| Simple comparison | Bubble, Selection, Insertion, Binary Insertion, Shell, Cocktail Shaker, Comb, Gnome, Odd-Even, Cycle, Pancake, Stooge, Bogo |
| Divide and conquer / data structures | Merge, Quick, Heap, Tim (simplified), Tree (BST) |
| Non-comparison (integers only) | Counting, Radix (LSD), Bucket, Pigeonhole |

> Bogo Sort uses the small array: with many elements it would take an impractical amount of time.
