internal class Restaurante
{
    private List<Mesa> mesas;
    private Cardapio cardapio;

    public Restaurante()
    {
        mesas = new List<Mesa>();
        cardapio = new Cardapio();
    }

    public void AdicionarMesa(Mesa mesa)
    {
        mesas.Add(mesa);
    }

    public void RemoverMesa(Mesa mesa)
    {
        mesas.Remove(mesa);
    }

    public List<Mesa> ObterMesas()
    {
        return mesas;
    }

    public Cardapio ObterCardapio()
    {
        return cardapio;
    }
}