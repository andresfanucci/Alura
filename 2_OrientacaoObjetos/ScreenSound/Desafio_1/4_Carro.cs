internal class Carro
{
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }

    public Carro(string modelo, string cor, int ano)
    {
        Modelo = modelo;
        Cor = cor;
        Ano = ano;
    }

    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando.");
    }

    public void Frear()
    {
        Console.WriteLine("O carro está freando.");
    }

    public void Buzinar()
    {
        Console.WriteLine("O carro está buzinando.");
    }
}