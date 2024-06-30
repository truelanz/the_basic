//Expressões Boleanas.
string myValue = "a";
Console.WriteLine(myValue.Equals("a  ")); //False
Console.WriteLine(myValue.Equals("A  ".Trim().ToLower())); //True Trim() remover espaços vazios.
Console.Clear();

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); //True
Console.WriteLine(!pangram.Contains("fox")); //False - Negação lógica
Console.WriteLine(pangram.Contains("cow")); //False
Console.WriteLine(pangram.StartsWith("The")); //True
Console.WriteLine(pangram.EndsWith("The")); //False

// Operador Condicional <condition> ? <if true return..> : <if false return..>
Console.WriteLine(pangram.Contains("quick") ? "The phrase contains \"quick\"" : "Not contains");

int saleAmount = 1001;
Console.WriteLine($"Desconto: {(saleAmount > 1000 ? 100 : 50)}");

// Cara ou Coroa com Operador Condicional
Random random = new();
int coin = random.Next(1, 3);
Console.WriteLine($"Result {coin} | {(coin == 1 ? "Cara" : "Coroa")}");

// Permissão de acordo com o lvl.
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else
        Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access.");
    else
        Console.WriteLine("You do not have sufficient privileges.");
}
else
    Console.WriteLine("You do not have sufficient privileges.");



