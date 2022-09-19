

public class Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private double prezzo;
    private double iva;

    public Prodotto(string nome, string descrizione, double prezzo, double iva)
    {
        this.codice = new Random().Next(100);
        this.nome = nome;
        this.prezzo = prezzo;
        this.descrizione = descrizione;
        this.iva = iva;
    }

    public int GetCodice()
    {
        return codice;
    }

    public string GetNome()
    {
        return nome;
    }

    public string GetNomeEsteso()
    {
        string nomeEsteso = nome + " " + codice;
        return nomeEsteso;
    }

    public string GetDescrizione()
    {
        return descrizione;
    }

    public double GetPrezzoBase()
    {
        return prezzo;
    }

    public double GetPrezzoIva()
    {
        return prezzo + iva;
    }

    public double GetIva()
    {
        return iva;
    }

    public int GetCodiceLungo()
    {
        string cod = Convert.ToString(codice);
        return Convert.ToInt32(cod.PadLeft(8,'0'));
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }

    public void SetPrezzo(double prezzo)
    {
        this.prezzo = prezzo;
    }

    public void SetIva(double iva)
    {
        this.iva = iva;
    }

}

