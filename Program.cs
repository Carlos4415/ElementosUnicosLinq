// Este programa utiliza LINQ para processar uma lista de números e retornar apenas os elementos únicos,
// ou seja, aqueles que aparecem apenas uma vez na lista. É uma solução prática para filtrar duplicatas
// em coleções de dados de forma eficiente.
List<int> numeros = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

var numerosUnicos = numeros.Distinct();

Console.WriteLine("Números únicos na lista:");

foreach (var numero in numerosUnicos)
{
    Console.WriteLine(numero + " ");
}