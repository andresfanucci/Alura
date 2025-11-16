internal class Conta
{
    //Atributos

    //Propriedades
    public Titular Titular { get; private set; }

    public int NumeroConta { get; private set; }
    public string Agencia { get; private set; }
    public double Saldo { get; private set; }
    public double Limite { get; private set; }
    public string Informacoes => $"Titular: {Titular.Nome}\n- CPF: {Titular.Cpf}\nConta: {NumeroConta}\nAgência: {Agencia}\nSaldo: {Saldo:C}\nLimite: {Limite:C}";

    //Métodos
    public void NovaConta(Titular titular)
    {
        Titular = titular;
        NumeroConta = GerarNumeroConta();
        Agencia = GerarAgencia();
        Saldo = 0.0;
        Limite = 1000.0;
    }

    private int GerarNumeroConta()
    {
        Random random = new Random();
        return random.Next(100000, 999999);
    }

    private string GerarAgencia()
    {
        Random random = new Random();

        return $"1-{random.Next(1000, 9999)}";
    }
}