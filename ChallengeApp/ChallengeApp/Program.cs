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

var Adam  = 0;
var Michal = 0;
var Jola = 0;
var Olaf = 0;
var Monika = 0;

for (var i=0; i<names.Count; i++)
{
    Console.WriteLine(names[i]);
}

    Console.WriteLine("==========");


for (var i = 0; i < names.Count; i++)

    if (names[i] == "Adam")
        Adam++;
    {
        Console.WriteLine($"Adam:   " + Adam);
    }

for (var i = 0; i < names.Count; i++)

    if (names[i] == "Michal")
        Michal++;
    {
        Console.WriteLine($"Michal: " + Michal);
    }

for (var i = 0; i < names.Count; i++)

    if (names[i] == "Jola")
        Jola++;
    {
        Console.WriteLine($"Jola:   " + Jola);
    }

for (var i = 0; i < names.Count; i++)

    if (names[i] == "Olaf")
        Olaf++;
    {
        Console.WriteLine($"Olaf:   " + Olaf);
    }

for (var i = 0; i < names.Count; i++)

    if (names[i] == "Monika")
        Monika++;
    {
        Console.WriteLine($"Monika: " + Monika);
    }
