

public class Prodotto
{
    private string codice;
    private string nome;
    private string descrizione;
    private double prezzo;
    private double iva;

    public Prodotto(string nome, string descrizione, double prezzo, double iva)
    {
        this.codice = Convert.ToString(new Random().Next(100));
        this.nome = nome;
        this.prezzo = prezzo;
        this.descrizione = descrizione;
        this.iva = iva;
    }

    public string GetCodice()
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

    public string GetCodiceLungo()
    {
        string stringa = "";
        int diff = 8 - codice.Length;
        if (diff > 0)
        {
            for (int i = 0; i < diff; i++)
            {
                stringa = stringa + "0";
            }
        }
        string codiceLungo = stringa + codice;
        return codiceLungo;
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

