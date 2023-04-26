using bytebank;

ContaCorrente contaDoCristiano = new ContaCorrente();

    contaDoCristiano.titular = "Cristiano Sousa";
    contaDoCristiano.numero_agencia = 15;
    contaDoCristiano.conta = "1010x";
    contaDoCristiano.saldo = 100;

Console.WriteLine("Saldo da conta do Cristiano " + contaDoCristiano.saldo);

