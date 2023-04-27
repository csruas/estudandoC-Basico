using bytebank;

ContaCorrente contaDoCristiano = new ContaCorrente();

    contaDoCristiano.titular = "Cristiano Sousa";
    contaDoCristiano.numero_agencia = 15;
    contaDoCristiano.conta = "1010x";
    contaDoCristiano.saldo = 100;

Console.WriteLine("Saldo da conta do Cristiano " + contaDoCristiano.saldo);

ContaCorrente contaDaClaudia = new ContaCorrente();
contaDaClaudia.titular = "Cláudia Vidal";
contaDaClaudia.numero_agencia = 16;
contaDaClaudia.conta = "22xxx-x";
contaDaClaudia.saldo = 350;

contaDoCristiano.Depositar(100);

Console.WriteLine("Saldo da conta do Cristiano depois de depositar " + contaDoCristiano.saldo);



if(contaDoCristiano.Sacar(200) == true)
{
    Console.WriteLine("Voce sacou  " + contaDoCristiano.saldo);
}
else
{
    Console.WriteLine("Voce não tem saldo suficiente. " );
}

Console.WriteLine("Transferindo....");
contaDoCristiano.Transferir(50, contaDaClaudia);

Console.WriteLine("Saldo da conta do Cristiano " + contaDoCristiano.saldo);
Console.WriteLine("Saldo da conta do Cládia " + contaDaClaudia.saldo);



