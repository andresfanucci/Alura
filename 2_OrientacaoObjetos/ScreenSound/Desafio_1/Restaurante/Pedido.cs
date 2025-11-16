internal class Pedido
{
    public Produto NomePrato { get; set; }
    public int Quantidade { get; set; }

    public Pedido(Produto nomePrato, int quantidade)
    {
        NomePrato = nomePrato;
        Quantidade = quantidade;
    }
}