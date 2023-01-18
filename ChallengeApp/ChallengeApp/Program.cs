//zadanie domowe dzien 4


string name = "Ewa";
char sex = 'K';
var age = 35;

if (sex == 'K' && age > 40)
{

    Console.WriteLine("Kobieta ponizej 40 lat");
}
else if (name == "Ewa" && age == 35)
{

    Console.WriteLine("Jestem Ewa lat 35");

}
else if (age < 18 && sex=='M')
{

    Console.WriteLine("Niepelnoletni mezczyzna");
}
    
else
{
    Console.WriteLine("Pelnoletni mezczyzna");
}