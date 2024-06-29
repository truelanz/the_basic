// See https://aka.ms/new-console-template for more information

//iniciar um array
string[] arry2 = {"um", "dois", "três", "quatro"};
Console.WriteLine(arry2[2]);
Console.WriteLine(arry2[3]);
Console.WriteLine(arry2.Length);
Console.WriteLine(arry2[0], "\n");

Console.Clear();

foreach (string names in arry2)
{
    Console.Write(names + ", ");
}

Console.WriteLine("");

int[] inventory = { 4, 8, 20, 50, 10 };
int sum = 0;
int bin = 0;
foreach (int itens in inventory)
{
    bin++;
    sum += itens;
    Console.WriteLine($"Compartimento {bin} = {itens} itens (Rodando total de {sum} itens)");
}
