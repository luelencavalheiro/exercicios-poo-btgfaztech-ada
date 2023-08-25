using System;


internal class Program
{
    static void Main(string[] args)
    {
        Futebol futebol = new Futebol();
        futebol.IniciarJogo();
        futebol.FinalizarJogo();
        futebol.ExibirDescricao();
    }
}

public abstract class EsporteBase
{
    public int QuantidadeJogadoresPorTime;
    public int TempoDeJogoEmMinutos;

    public abstract void IniciarJogo();
    public abstract void FinalizarJogo();
    public abstract void ExibirDescricao();

}

public class Futebol : EsporteBase
{
    public Futebol()
    {
        QuantidadeJogadoresPorTime = 11;
        TempoDeJogoEmMinutos = 90;
    }

    public override void IniciarJogo()
    {
        Console.WriteLine("O jogo foi iniciado");
    }
    public override void FinalizarJogo()
    {
        Console.WriteLine("O jogo foi finalizado");
    }
    public override void ExibirDescricao()
    {
        Console.WriteLine($"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime} jogadores em cada time durante {TempoDeJogoEmMinutos} minutos");
    }
}
