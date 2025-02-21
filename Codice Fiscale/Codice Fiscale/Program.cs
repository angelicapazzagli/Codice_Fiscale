void vc(string parola, ref string v, ref string c, ref int nv, ref int nc)
{
    for (int i = 0; i < parola.Length; i++)
    {
        if (parola[i] == 'a' || parola[i] == 'e' || parola[i] == 'i' || parola[i] == 'o' || parola[i] == 'u')
        {
            v += parola[i];
            nv++;
        }
        else
        {
            nc++;
            c += parola[i];
        }
    }
}
Console.WriteLine("Cognome da nubile");
string cognome1 = Console.ReadLine();
Console.WriteLine("Nome");
string nome1 = Console.ReadLine();
Console.WriteLine("Anno di nascita");
string anno1 = Console.ReadLine();
Console.WriteLine("Mese di nascita (caratteri)");
string mese = Console.ReadLine();
Console.WriteLine("Giorno di nascita (cifre)");
int giorno = Int32.Parse(Console.ReadLine());
Console.WriteLine("Sesso");
string sesso = Console.ReadLine();
string cognome = cognome1.Replace(" ", "");
string nome = nome1.Replace(" ", "");
string c_cognome = "", v_cognome = "", codice_fiscale = "", c_nome = "", v_nome = "";
int nvc = 0, ncc = 0, nvn = 0, ncn = 0;
vc(cognome, ref v_cognome, ref c_cognome, ref nvc, ref ncc);
Console.WriteLine(c_cognome);
Console.WriteLine(v_cognome);
if (ncc >= 3)
{
    codice_fiscale += c_cognome[0] + c_cognome[1] + c_cognome[2];
}
else if (ncc == 2)
{
    codice_fiscale += c_cognome[0] + c_cognome[1] + v_cognome[0];
}
else if (ncc == 1 && nvc == 2)
{
    codice_fiscale += c_cognome[0] + v_cognome[0] + v_cognome[1];
}
else if (ncc == 1 && nvc == 1)
{
    codice_fiscale += c_cognome[0] + v_cognome[0] + "x";
}
else if (nvc == 2)
{
    codice_fiscale += v_cognome[0] + v_cognome[1] + "x";
}
vc(nome, ref v_nome, ref c_nome, ref nvn, ref ncn);
if (ncn >= 4)
{
    codice_fiscale += c_nome[0] + c_nome[2] + c_nome[3];
}
else if (ncn == 3)
{
    codice_fiscale += c_nome[0] + c_cognome[1] + c_nome[2];
}
else if (ncn == 2)
{
    codice_fiscale += c_nome[0] + c_nome[1] + v_nome[0];
}
else if (ncn == 1 && nvn == 2)
{
    codice_fiscale += c_nome[0] + v_nome[0] + "x";
}
else if (ncn == 1 && nvn == 1)
{
    codice_fiscale += v_nome[0] + v_nome[1] + "x";
}
else if (nvn == 2)
{
    codice_fiscale += v_nome[0] + v_nome[1] + "x";
}
string anno = anno1.Substring(2);
codice_fiscale += anno;
if(mese == "gennaio")
{
    codice_fiscale += "a";
}
else if (mese == "febbraio")
{
    codice_fiscale += "b";
}
else if (mese == "marzo")
{
    codice_fiscale += "c";
}
else if (mese == "aprile")
{
    codice_fiscale += "d";
}
else if (mese == "maggio")
{
    codice_fiscale += "e";
}
else if (mese == "giugno")
{
    codice_fiscale += "h";
}
else if (mese == "luglio")
{
    codice_fiscale += "l";
}
else if (mese == "agosto")
{
    codice_fiscale += "m";
}
else if (mese == "settembre")
{
    codice_fiscale += "p";
}
else if (mese == "ottobre")
{
    codice_fiscale += "r";
}
else if (mese == "novembre")
{
    codice_fiscale += "s";
}
else if (mese == "dicembre")
{
    codice_fiscale += "t";
}
if(sesso == "femmina")
{
    codice_fiscale += (giorno + 40);
}
else if(sesso == "maschio")
{
    if(giorno < 10)
    {
        codice_fiscale += "0" + giorno;
    }
    else 
    { 
        codice_fiscale += giorno;
    }
}
Console.WriteLine(codice_fiscale.ToUpper());
