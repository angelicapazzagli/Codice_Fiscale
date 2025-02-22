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
Console.WriteLine("Data di nascita (GG/MESE/ANNO) es. 30/12/2008");
string data = Console.ReadLine();
Console.WriteLine("Sesso (m o f)");
string sesso = Console.ReadLine();
string cognome = cognome1.Replace(" ", "");
string nome = nome1.Replace(" ", "");
string c_cognome = "", v_cognome = "", codice_fiscale = "", c_nome = "", v_nome = "";
int nvc = 0, ncc = 0, nvn = 0, ncn = 0;
string[] mesi = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
string[] l_mesi = { "a", "b", "c", "d", "e", "h", "l", "m", "p", "r", "s", "t" };
vc(cognome, ref v_cognome, ref c_cognome, ref nvc, ref ncc);
Console.WriteLine();
Console.WriteLine();
if (ncc >= 3)
{
    codice_fiscale += c_cognome[0];
    codice_fiscale += c_cognome[1];
    codice_fiscale +=  c_cognome[2];
}
else if (ncc == 2)
{
    codice_fiscale += c_cognome[0];
    codice_fiscale += c_cognome[1];
    codice_fiscale += v_cognome[0];
}
else if (ncc == 1 && nvc == 2)
{
    codice_fiscale += c_cognome[0];
    codice_fiscale += v_cognome[0];
    codice_fiscale += v_cognome[1];
}
else if (ncc == 1 && nvc == 1)
{
    codice_fiscale += c_cognome[0];
    codice_fiscale += v_cognome[0];
    codice_fiscale += "x";
}
else if (nvc == 2)
{
    codice_fiscale += v_cognome[0];
    codice_fiscale += v_cognome[1];
    codice_fiscale += "x";
}
vc(nome, ref v_nome, ref c_nome, ref nvn, ref ncn);
if (ncn >= 4)
{
    codice_fiscale += c_nome[0];
    codice_fiscale +=  c_nome[2];
    codice_fiscale += c_nome[3];
}
else if (ncn == 3)
{
    codice_fiscale += c_nome[0];
    codice_fiscale += c_cognome[1];
    codice_fiscale += c_nome[2];
}
else if (ncn == 2)
{
    codice_fiscale += c_nome[0];
    codice_fiscale += c_nome[1];
    codice_fiscale += v_nome[0];
}
else if (ncn == 1 && nvn == 2)
{
    codice_fiscale += c_nome[0];
    codice_fiscale += v_nome[0];
    codice_fiscale += "x";
}
else if (ncn == 1 && nvn == 1)
{
    codice_fiscale += v_nome[0];
    codice_fiscale += v_nome[1];
    codice_fiscale += "x";
}
else if (nvn == 2)
{
    codice_fiscale += v_nome[0];
    codice_fiscale += v_nome[1];
    codice_fiscale += "x";
}
string anno = data.Substring(8);
codice_fiscale += anno;
string mese = data.Substring(3, 5);
for(int i = 0; i < mesi.Length; i++)
{
    if (mese.Contains(mesi[i]))
    {
        codice_fiscale += l_mesi[i];
    }
}
string giorno1 = data.Substring(0, 2);
int giorno = int.Parse(giorno1);
if(sesso == "f")
{
    codice_fiscale += (giorno + 40);
}
else 
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
