Conta conta = new Conta();
Titular titular = new Titular("Ana Silva", "123.456.789-00");
conta.NovaConta(titular);
Console.WriteLine(conta.Informacoes);

Console.WriteLine("=======================================================");

Produto produto1 = new Produto();
produto1.AdicionarNovo("Notebook", 3500.00, 10);
Produto produto2 = new Produto();
produto2.AdicionarNovo("Smartphone", 1500.00, 20);
Estoque estoque = new Estoque();
estoque.AdicionarProduto(produto1);
estoque.AdicionarProduto(produto2);
foreach (var produto in estoque.ListarProdutos())
{
    Console.WriteLine(produto.Informacoes);
    Console.WriteLine("-------------------------------------------------------");
}