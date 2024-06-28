
/* exibir uma mensagem de renovação quando um usuário fizer logon no sistema de software e receber a notificação
 de que a assinatura está prestes a ser encerrada */

/* Regra 1: seu código deve exibir apenas uma mensagem.
A mensagem exibida pelo código dependerá das outras cinco regras. Para as regras de 2 a 6, as regras numeradas mais
altas têm precedência sobre as regras numeradas mais baixas.

Regra 2: se a assinatura do usuário expirar em dez dias ou menos, será exibida a mensagem:
Your subscription will expire soon. Renew now!

Regra 3: se a assinatura do usuário expirar em cinco dias ou menos, será exibida a mensagem:
Your subscription expires in _ days.
Renew now and save 10%!

 Regra 4: se a assinatura do usuário expirar em um dia, serão exibidas as mensagens: 
Your subscription expires within a day!
Renew now and save 20%!

Regra 5: se a assinatura do usuário tiver expirado, será exibida a mensagem:
Your subscription has expired.

Regra 6: se a assinatura do usuário não expirar em dez dias ou menos, não será exibida nenhuma mensagem.
 */

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day! Renew now and save 20%!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days! Renew now and save 10%!");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
