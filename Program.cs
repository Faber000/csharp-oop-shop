

Prodotto prodotto = new Prodotto("iphone 14", "iphone di ultima generazione", 999.99);
prodotto.SetNome("Iphone 14 Pro");
Console.WriteLine("il prodotto " + prodotto.GetNome() + " avente codice " +prodotto.GetCodice()+" costa " + prodotto.GetPrezzoIva() + "$ Iva compresa");
Console.WriteLine("descrizione prodotto num. " + prodotto.GetCodiceLungo() + ": " + prodotto.GetDescrizione());

