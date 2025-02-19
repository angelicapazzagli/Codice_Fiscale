void consonanti_vocali(string nec, string vocali, ref string codice_fiscale, ref int n_consonanti, ref int n_vocali, ref string c, ref string v) 
{
    for (int i = 0; i < nec.Length; i++)
    {
        int a = 0;
        while(a != 0)
        for (int j = 0; j < vocali.Length; j++)
        {
            if (nec[i] != vocali[j])
            {
                c += nec[i];
                n_consonanti++;
            }
            else
            {
                v+= nec[i];
                n_vocali++;
            }
        }
    }
}
Console.WriteLine("Cognome da nubile");
string cognome = Console.ReadLine();
Console.WriteLine("Nome");
string nome = Console.ReadLine();

string cognome1 = cognome.Replace(" ", "");
string nome1 = nome.Replace(" ", "");
string vocali = "aeiou", codice_fiscale = "", c_cognome = "", v_cognome = "";
int n_consonanti = 0, n_vocali = 0;
consonanti_vocali(cognome1, vocali, ref codice_fiscale, ref n_consonanti, ref n_vocali, ref c_cognome, ref v_cognome);
if(n_consonanti >= 3)
{
    for(int i = 0; i < 3; i++)
    {
        codice_fiscale += c_cognome[i];
    }
}
Console.WriteLine(codice_fiscale);
