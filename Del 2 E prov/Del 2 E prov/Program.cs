//För det första måste jag göra två listor, en för att ha domarens namn, andra för att lagra  slumptal.. deras betyg

string [] domare = {
    "Imad",
    "Janan",
    "Adam",
    "Kerem",
    "Saymmon"
};

//här ska vi använda double, för att kunna lagra dessa tal

double [] betyg = new Double[5]; //Vi skriver fem eftersom det finns fem personer, fem domare

Random rnd = new Random(); // Vi skapar en genererare som ska funka att generera slumptal mellan 1.0 och 10.0

// här blir det svårt, eftersom jag måste använda math.round och glömde hur..

for (int i = 0; i < betyg.Length; i++)
{
    betyg[i] = Math.Round(rnd.NextDouble(Math.Round)) *1.0 10.0 1; //Här skulle man göra att man skriver ut decimal slumptal, men man avrundar de till t.ex. 1.2
    

}

