internal class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public bool RemoverProduto(string nome)
    {
        var produto = produtos.FirstOrDefault(p => p.Nome == nome);
        if (produto != null)
        {
            produtos.Remove(produto);
            return true;
        }
        return false;
    }

    public Produto BuscarProduto(string nome)
    {
        return produtos.FirstOrDefault(p => p.Nome == nome)!;
    }

    public List<Produto> ListarProdutos()
    {
        return produtos;
    }
}