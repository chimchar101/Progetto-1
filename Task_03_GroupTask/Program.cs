using System;
using System.Security.Cryptography.X509Certificates;

public class Corso
{
    public string NomeCorso;
    public int DurataOre;
    public string Docente;
    public List<string> Studenti;
    public Corso(string nomeCorso, int durataOre, string docente, List<string> studenti)
    {
        NomeCorso = nomeCorso;
        DurataOre = durataOre;
        Docente = docente;
        Studenti = studenti;
    }

    public void AggiungiStudente(string nomeStudente)//* FATTO
    {
        Studenti.Add(nomeStudente);
    }

    public virtual string ToString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Studenti: {Studenti}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("Ciao Campione");
    }
}

public class CorsoPittura : Corso//! Andrea Fabbri @gijntheplug on github
{
    public string Tecnica;
    public CorsoPittura(string nomeCorso, int durataOre, string docente, List<string> studenti, string tecnica) : base(nomeCorso, durataOre, docente, studenti)
    {
        Tecnica = Tecnica;
    }
    public override string ToString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti: {Studenti} | Tecnica utilizzata: {Tecnica}";
    }
    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si usa la tecnica: {Tecnica}");
    }
}
