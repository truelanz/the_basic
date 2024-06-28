// See https://aka.ms/new-console-template for more information

// WriteLine (executa o próximo output na linha abaixo)
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
// Write (executa o próximo output na mesma linha)
Console.Write("Hello, World!");

Console.WriteLine();

//char como caractere literal
Console.WriteLine('b');

/* 
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits (Padrão do compilador)
decimal        28-29 digits
 */

 // Pode usar f ou F para sufixo literal pra float, e m para sufixo literal de decimal
 Console.WriteLine(0.25F);

// casting explícito
decimal y = 3.99m;
int converty = (int)y;
Console.WriteLine(converty);

/*
Criar uma variável tipada impricitamente usan "var" 
A palavra-chave var é usada para salvar em pressionamentos
de tecla quando os tipos são longos ou quando o tipo é óbvio no contexto.
 */
var message = "Uma msg qualquer";
var number = 5.8f;

Console.WriteLine("Pulando uma linha\n Inserindo um espaço tabulado \t \"inserindo dupla aspas\"");
Console.WriteLine("Para\\Exibir\\uma\\barra\\invertida\\simples\\usa\\duas\\barras");

//Cadeia de caractere textual, onde a formatação fica exatamente igual à escrita;
Console.WriteLine(@"  c:\teste\t\ \n
                (exemplo    texte)");

string projectName = "ACME";

Console.WriteLine("View English output:");
Console.Write($"    c:\\Exercise\\{projectName}\\data.txt");    

var d = "diretorio";
d = d + @"\";
Console.WriteLine($"\n{d}");

// Resto da divisão
Console.WriteLine($"O resto de 200 / 4 é: {200 % 3}");

/* 
PEMDAS - Ordem de operação:
1. Parêntese (o que estiver dentro do parêntese é executado primeiro)
2. Exponentes
3. Multiplicação e Divisão (da esquerda para a direita)
4. Adição e Subtração (da esquerda para a direita)
 */

//Convertendo fahrenheit em celcius
int fahrenheit = 94;
var result = ((decimal)fahrenheit - 32) * 5 / 9;
Console.WriteLine($"The temperature is {result} Celsius");

int j = 3 + 1 * 5 / 2;
Console.WriteLine(5 / 10);

//limpar console
Console.Clear();  

//Chamar objeto - método com estado
Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

Console.Clear();

//O maior número
Random random = new();
int num1 = random.Next(1,20);
int num2 = random.Next(1,20);
Console.WriteLine(num1 + ", " + num2);

int greatest = Math.Max(num1, num2);
Console.WriteLine(greatest);