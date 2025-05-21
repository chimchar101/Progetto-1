using System;

public class Corso
{
    public string NomeCorso, Docente;
    public int DurataOre;
    public List<string> Studenti;

    public Corso(string nomeCorso, string docente, int durataOre, List<string> studenti)
    {
        NomeCorso = nomeCorso;
        Docente = docente;
        DurataOre = durataOre;
        Studenti = studenti;
    }

    public void AggiungiStudente(string nomeStudente) // FATTO
    {
        Studenti.Add(nomeStudente);
    }

    public virtual string ToString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti: {Studenti}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("Ciao campione");
    }
}

public class CorsoDanza : Corso
{
    public string Stile;
    public CorsoDanza(string nomeCorso, string docente, int durataOre, List<string> studenti, string stile) : base(nomeCorso, docente, durataOre, studenti)
    {
        Stile = stile;
    }

    
    public override string ToString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti: {Studenti} | Stile: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}");
    }
}