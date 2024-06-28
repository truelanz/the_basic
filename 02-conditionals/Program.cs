

Random dice = new();

// Dados com 6 lados cada, com valor de 1 a 6
int roll1 = dice.Next(1, 7); 
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Os Dados foram jogados: {roll1} + {roll2} + {roll3} = {total}");

// Condição, bloco aninhado, caso o bloco de dentro seja falso, ele retornará verdadeiro para o bloco de fora.
// Como um XOR.
if ((roll1 == roll2) ^ (roll1 == roll3) ^ (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine($"Você obteve 6 pontos bônus"); 
        total += 6;    
    }
    else{
    Console.WriteLine($"Você obteve 2 pontos bônus");
    total += 2;
    }
}

if (total >= 20)
{
    Console.WriteLine("Você ganhou uma casa!");
}
else if (total >= 16)
{
    Console.WriteLine("Você ganhou um carro!");
}
else if (total >= 13)
{
Console.WriteLine("Você ganhou uma viagem!");
}
else if (total <= 12)
{
Console.WriteLine("Que pena! Você não ganhou nada");
    }
Console.WriteLine($"Seu total de ponto foi: {total}");
