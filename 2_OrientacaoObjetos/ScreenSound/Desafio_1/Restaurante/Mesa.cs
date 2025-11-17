internal class Mesa
{
    private List<Pedido> pedidos;

    public Mesa()
    {
        pedidos = new List<Pedido>();
    }

    public void AdicionarPedido(Pedido pedido)
    {
        pedidos.Add(pedido);
    }

    public void RemoverPedido(Pedido pedido)
    {
        pedidos.Remove(pedido);
    }

    public List<Pedido> ObterPedidos()
    {
        return pedidos;
    }
}