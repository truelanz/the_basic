
//iteração com i++
for (int i = 0; i < 10; i++)
{
    Console.Write($"{i} ");
}
Console.Clear();

//iteração com i--
for (int i = 10; i >= 0; i--)
{
    Console.Write($"{i} ");
}
Console.Clear();

//iteração com i-- (De trás para frente.)
for (int i = 10; i > 0; i--)
{
    Console.Write($"{i} ");
}
Console.Clear();

//iteração pulando números
for (int i = 0; i < 10; i += 2)
{
    Console.Write($"{i} ");
}
Console.Clear();

//Iterando somente números pares
for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");
}
Console.Clear();

//atendendo condição e parando loop com brak
 for (int i = 0; i <= 10; i++)
{
    Console.Write($"{i} ");
    if (i >= 7) break;
}
Console.Clear();

/***********************************************************/

//Percorrendo Matriz
string[] names = { "truelanz", "páprica doce", "páprica defumada"};
for (int i = 0; i <= names.Length - 1; i++)
{
    Console.Write($"Name: {names[i]} | ");
}
Console.Clear();

//Percorrendo Matriz de trás para frente
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.Write($"Name: {names[i]} | ");
}
Console.Clear();

//Alterar um valor dentro de um loop for
for (int i = 0; i <= names.Length - 1; i++)
{
    if (names[i] == "páprica defumada".Trim().ToLower())
        names[i] = "páprica picante";
    Console.Write($"Name: {names[i]} | ");
}