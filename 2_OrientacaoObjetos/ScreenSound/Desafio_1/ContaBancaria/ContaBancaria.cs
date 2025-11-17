internal class Conta
{
    //Construtor
    public Conta(Titular titular)
    {
        Random random = new Random();
        NumeroConta = random.Next(100000, 999999);
        Agencia = $"1-{random.Next(1000, 9999)}";
        Titular = titular;
        Saldo = 0.0;
        Limite = 1000.0;
    }

    //Atributos

    //Propriedades
    public Titular Titular { get; private set; }

    public int NumeroConta { get; private set; }
    public string Agencia { get; private set; }
    public double Saldo { get; private set; }
    public double Limite { get; private set; }
    public string Informacoes => $"Titular: {Titular.Nome}\n- CPF: {Titular.Cpf}\nConta: {NumeroConta}\nAgência: {Agencia}\nSaldo: {Saldo:C}\nLimite: {Limite:C}";

    //Métodos
}