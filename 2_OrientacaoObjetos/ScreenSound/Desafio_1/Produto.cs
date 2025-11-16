using System.Runtime.InteropServices.Swift;

internal class Produto
{
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int QuantidadeEstoque { get; private set; } = 0;

    public string Informacoes => $"Produto: {Nome}\nPreço: {Preco:C}\nQuantidade em Estoque: {QuantidadeEstoque}";

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEstoque += quantidade;
        }
    }

    public bool RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QuantidadeEstoque)
        {
            QuantidadeEstoque -= quantidade;
            return true;
        }
        return false;
    }

    public void AdicionarNovo(string nome, double preco, int quantidadeEstoque)
    {
        Nome = nome;
        Preco = preco;
        AdicionarEstoque(quantidadeEstoque);
    }
}