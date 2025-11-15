internal class Conta
{
    //Atributos
    public int numeroIndicador;

    public string titular;
    public double saldo;
    public string senha;

    //Métodos
    public void ExibirInformacoes()
    {
        Console.WriteLine("Número do Indicador: " + numeroIndicador);
        Console.WriteLine("Titular: " + titular);
        Console.WriteLine("Saldo: R$ " + saldo);
    }
}