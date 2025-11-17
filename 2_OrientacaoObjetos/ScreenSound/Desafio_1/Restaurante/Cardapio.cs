internal class Cardapio
{
    private List<Produto> produtos;

    public Cardapio()
    {
        produtos = new List<Produto>();
    }

    public void AdicionarItem(Produto item)
    {
        produtos.Add(item);
    }

    public void RemoverItem(Produto item)
    {
        produtos.Remove(item);
    }

    public List<Produto> ObterItens()
    {
        return produtos;
    }
}