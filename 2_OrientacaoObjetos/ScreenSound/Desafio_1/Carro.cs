internal class Carro
{
    private int ano;
    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public string Cor { get; set; }

    public int Ano
    {
        get => ano;
        set
        {
            if (value < 1960 || value > DateTime.Now.Year + 1)
            {
                throw new ArgumentOutOfRangeException("Ano", $"O ano ({value}) deve estar entre 1960 e o próximo ano ({DateTime.Now.Year + 1}).");
            }
            else
            {
                ano = value;
            }
        }
    }

    public string DescricaoDetalhada => $"{Modelo} - {Fabricante} - {Cor} - {Ano}";

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