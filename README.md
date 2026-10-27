Insertion Sort in C#

A small console application that demonstrates the Insertion Sort algorithm in C#, sorting the same array first in descending order and then in ascending order.

How it works

Insertion Sort builds the sorted portion of the array one element at a time. For each element (the "key"), it shifts the larger (or smaller) elements of the sorted portion one position to the right and inserts the key in its correct place.

Method	Order	Condition in the while loop
InsertionSort	Descending (high → low)	arr[j] < chave
InsertDesc	Ascending (low → high)	arr[j] > chave

Note: despite its name, InsertDesc sorts in ascending order. Consider renaming it to InsertAsc to avoid confusion.

Program flow
Creates an array of 50 unsorted integers.
Prints the original array.
Sorts it in descending order with InsertionSort and prints the result.
Sorts it in ascending order with InsertDesc and prints the result.
Complexity
Case	Time	Space
Best	O(n)	O(1)
Average	O(n²)	O(1)
Worst	O(n²)	O(1)

The algorithm sorts in place and is stable.

Requirements
.NET SDK (LTS version recommended)
Visual Studio Code with the C# Dev Kit extension (optional)
Running the project

From the project folder (the one containing the .csproj file):

bash
dotnet run
Example output
Vetor Original
64, 34, 25, 12, 11, 90, 20, 29, 99, 68, ...

Vetor Ordenado (decrescente)
99, 97, 95, 93, 91, 90, 88, ... 6, 3, 1

Vetor Ordenado (crescente)
1, 3, 6, 8, 10, 11, 12, ... 95, 97, 99
Project structure
InsertionSort_Ordenacao/
├── Program.cs
├── InsertionSort_Ordenacao.csproj
└── README.md
