
// Variável Local - iniciada em um bloco de código
bool flag = true;
if (flag)
{
    string localVariable = "Local Variable";
    Console.WriteLine($"Dentro do bloco de código \"{localVariable}\"");
}

//Variável Global - iniciada fora de blocos de código
bool flag2 = true;
string globalVariable = "";
if (flag2)
    globalVariable = "Global Variable";
    Console.WriteLine($"Executando dentro do bloco \"{globalVariable}\"");

Console.WriteLine($"\"{globalVariable}\" também pode ser executada fora do bloco");
Console.Clear();

/******************************************************************************/
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0; 

foreach (int number in numbers)
{
    total += number;
    if (number == 23)
       found = true;
}
if (found) 
    Console.WriteLine("Set contains 23");

Console.WriteLine($"Total: {total}");