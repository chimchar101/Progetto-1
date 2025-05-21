using System;

public class Corso
{
    public string NomeCorso;
    public int DurataOre;
    public int Docente;

    public List<string> Studenti;

    public Corso(string nomeCorso, int durataOre, int docente, List<string> studenti)
    {
        NomeCorso = nomeCorso;
        DurataOre = durataOre;
        Docente = docente;
        Studenti = studenti;
    }

    public void AggiungiStudente(string nomeStudente) //FATTO
    {
        Studenti.Add(nomeStudente);
    }
    public virtual string toString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti {Studenti}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("Ciao campione");
    }
}

public class CorsoMusica : Corso
{
    public string Strumento;

    public CorsoMusica(string nomeCorso, int durataOre, int docente, List<string> studenti, string strumento) : base(nomeCorso, durataOre, docente, studenti)
    {
        Strumento = strumento;
    }

    public override string toString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti {Studenti} | Strumento utilizzato: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}");
    }
}
