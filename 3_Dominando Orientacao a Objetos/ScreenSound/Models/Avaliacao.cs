namespace ScreenSound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string str)
    {
        int nota = int.Parse(str);
        return new Avaliacao(nota);
    }
}