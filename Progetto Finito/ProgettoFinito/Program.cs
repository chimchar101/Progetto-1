using System;

// Creazione classe base Corso
public class Corso
{
    public string NomeCorso, Docente;
    public int DurataOre;
    public List<string> Studenti;

    public Corso(string nomeCorso, string docente, int durataOre, List<string> studenti) // Costruttore di Corso
    {
        NomeCorso = nomeCorso;
        Docente = docente;
        DurataOre = durataOre;
        Studenti = studenti;
    }

    public void AggiungiStudente(string nomeStudente) // Metodo che aggiunge i nomi degli studenti alla lista Studenti
    {
        Studenti.Add(nomeStudente);
    }

    public virtual string ToString() // Verrà ereditato dai figli che aggiungono le rispettive variabili con override, usato per stampare i dati dei corsi
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti: {Studenti}";
    }

    public virtual void MetodoSpeciale() // Verrà ereditato dai figli che con override stamperanno la linea con la loro variabile esclusiva
    {
        Console.WriteLine("Ciao campione");
    }
}

// Creazione classe CorsoMusica derivata da Corso
public class CorsoMusica : Corso //! Carlo Condello @carlocond on github
{
    public string Strumento;

    public CorsoMusica(string nomeCorso, string docente, int durataOre, List<string> studenti, string strumento) : base(nomeCorso, docente, durataOre, studenti)
    {
        Strumento = strumento;
    }

    public override string ToString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti: {Studenti.Count()} | Strumento utilizzato: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}");
    }
}

// Creazione classe CorsoPittura derivata da Corso
public class CorsoPittura : Corso //! Andrea Fabbri @gijntheplug on github
{
    public string Tecnica;
    public CorsoPittura(string nomeCorso, string docente, int durataOre, List<string> studenti, string tecnica) : base(nomeCorso, docente, durataOre, studenti)
    {
        Tecnica = tecnica;
    }
    public override string ToString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti: {Studenti.Count()} | Tecnica utilizzata: {Tecnica}";
    }
    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si usa la tecnica: {Tecnica}");
    }
}

// Creazione classe CorsoDanza derivata da Corso
public class CorsoDanza : Corso //! Simone Addesso @chimchar101 on github
{
    public string Stile;
    public CorsoDanza(string nomeCorso, string docente, int durataOre, List<string> studenti, string stile) : base(nomeCorso, docente, durataOre, studenti)
    {
        Stile = stile;
    }


    public override string ToString()
    {
        return $"Nome corso: {NomeCorso} | Durata ore: {DurataOre} | Docente: {Docente} | Studenti: {Studenti.Count()} | Stile: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Corso> corsi = new List<Corso>();
        int scelta;
        bool esci = false;

        do
        {
            Console.WriteLine("Benvenuto. Cosa vuoi fare?");
            Console.WriteLine("[1] Aggiungi un corso di Musica\n[2] Aggiungi un corso di Pittura\n[3] Aggiungi un corso di Danza\n[4] Aggiungi studente a un corso");
            Console.WriteLine("[5] Visualizza tutti i corsi\n[6] Cerca corsi per nome docente\n[7] Esegui metodo speciale di un corso\n[0] Esci");
            scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1: // Inserimento corso di Musica
                    AggiungiMusica(corsi);
                    break;
                case 2: // Inserimento corso di Pittura
                    AggiungiPittura(corsi);
                    break;
                case 3: // Inserimento corso di Danza
                    AggiungiDanza(corsi);
                    break;
                case 4: // Inserisce studente ad un corso a scelta dell'utente
                    AggiungiStudente(corsi);
                    break;
                case 5: // Stampa tutti i corsi
                    StampaCorsi(corsi);
                    break;
                case 6: // Stampa solo corsi con il docente inseriti in input dall'utente
                    CercaDocente(corsi);
                    break;
                case 7:
                    EseguiMetodoSpeciale(corsi);
                    break;
                case 0:
                    Console.WriteLine("Arrivederci campione!");
                    esci = true; // Cambia esci in true per finire il ciclo una volta finito
                    break;
                default:
                    Console.WriteLine("ERRORE INPUT - Ritorno al menù.");
                    break;
            }
        } while (!esci);
    }

    private static void AggiungiMusica(List<Corso> corsi)
    {
        List<string> studenti = new List<string>();
        Console.WriteLine("Inserisci nome del corso:");
        string nomeCorso = Console.ReadLine();
        Console.WriteLine("Inserisci la durata del corso in ore:");
        int durata = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il nome del docente:");
        string nomeDocente = Console.ReadLine();
        Console.WriteLine("Inserisci lo strumento insegnato nel corso:");
        string strumento = Console.ReadLine();

        CorsoMusica corsoMusica = new CorsoMusica(nomeCorso, nomeDocente, durata, studenti, strumento);
        corsi.Add(corsoMusica);
        Console.WriteLine("Corso inserito!");
    }

    private static void AggiungiPittura(List<Corso> corsi)
    {
        List<string> studenti = new List<string>();
        Console.WriteLine("Inserisci nome del corso:");
        string nomeCorso = Console.ReadLine();
        Console.WriteLine("Inserisci la durata del corso in ore:");
        int durata = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il nome del docente:");
        string nomeDocente = Console.ReadLine();
        Console.WriteLine("Inserisci la tecnica insegnata nel corso:");
        string tecnica = Console.ReadLine();

        CorsoPittura corsoPittura = new CorsoPittura(nomeCorso, nomeDocente, durata, studenti, tecnica);
        corsi.Add(corsoPittura);
        Console.WriteLine("Corso inserito!");
    }

    private static void AggiungiDanza(List<Corso> corsi)
    {
        List<string> studenti = new List<string>();
        Console.WriteLine("Inserisci nome del corso:");
        string nomeCorso = Console.ReadLine();
        Console.WriteLine("Inserisci la durata del corso in ore:");
        int durata = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il nome del docente:");
        string nomeDocente = Console.ReadLine();
        Console.WriteLine("Inserisci lo stile insegnato nel corso:");
        string stile = Console.ReadLine();

        CorsoDanza corsoDanza = new CorsoDanza(nomeCorso, nomeDocente, durata, studenti, stile);
        corsi.Add(corsoDanza);
        Console.WriteLine("Corso inserito!");
    }

    private static void AggiungiStudente(List<Corso> corsi)
    {
        for (int i = 0; i < corsi.Count; i++)
        {
            Console.WriteLine($"CORSO {i + 1} | {corsi[i].ToString()}");
        }

        Console.WriteLine("A quale corso vuoi inserire uno studente? (Inserisci numero del corso)");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il nome dello studente:");
        string studente = Console.ReadLine();
        corsi[c - 1].AggiungiStudente(studente);

        Console.WriteLine("Studente aggiunto!");
    }
    private static void StampaCorsi(List<Corso> corsi)
    {
        foreach (Corso corso in corsi)
        {
            Console.WriteLine(corso.ToString());
        }
    }

    private static void CercaDocente(List<Corso> corsi)
    {
        Console.WriteLine("Inserisci il nome di un professore per trovare i suoi corsi:");
        string prof = Console.ReadLine();
        foreach (Corso corso in corsi)
        {
            if (corso.Docente.ToLower() == prof.ToLower())
            {
                Console.WriteLine(corso.ToString());
            }
        }
    }

    private static void EseguiMetodoSpeciale(List<Corso> corsi)
    {
        for (int i = 0; i < corsi.Count; i++)
        {
            Console.WriteLine($"CORSO {i + 1} | {corsi[i].ToString()}");
        }

        Console.WriteLine("Di quale corso vuoi eseguire il metodo speciale? (Inserisci numero del corso)");
        int c = int.Parse(Console.ReadLine());
        corsi[c - 1].MetodoSpeciale();
    }
}