//zadanie domowe dzien 5
int[] grades = new int[20];

List<string> names = new List<string>();
names.Add("Adam");
names.Add("Adam");
names.Add("Adam");
names.Add("Michal");
names.Add("Adam");
names.Add("Monika");
names.Add("Olaf");
names.Add("Adam");
names.Add("Olaf");
names.Add("Jola");
names.Add("Adam");
names.Add("Monika");
names.Add("Adam");
names.Add("Olaf");
names.Add("Michal");
names.Add("Monika");
names.Add("Michal");
names.Add("Olaf");
names.Add("Jola");
names.Add("Michal");

var AdamCount = 0;
var MichalCount = 0;
var JolaCount = 0;
var OlafCount = 0;
var MonikaCount = 0;

for (var i=0; i<names.Count; i++)
{
    Console.WriteLine(names[i]);
}

    Console.WriteLine("==========");


for (var i = 0; i < names.Count; i++)
{
    if (names[i] == "Adam")
    {
        AdamCount++;
    }

    else if (names[i] == "Michal")
    {
        MichalCount++;
    }

    else if (names[i] == "Jola")
    {
        JolaCount++;
    }

    else if (names[i] == "Olaf")
    {
        OlafCount++;
    }
    else if (names[i] == "Monika")
    { 
        MonikaCount++;
    }    
}

Console.WriteLine("Adam:   " + AdamCount);
Console.WriteLine("Michal: " + MichalCount);
Console.WriteLine("Jola:   " + JolaCount);
Console.WriteLine("Olaf:   " + OlafCount);
Console.WriteLine("Monika: " + MonikaCount);
