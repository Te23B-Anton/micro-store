bool success = false;
int ageNum = 0;

while (success != true)
{



  Console.WriteLine("ålder:");
  string age = Console.ReadLine();


  success = int.TryParse(age, out ageNum);

  if (success == false)
  {
    Console.WriteLine("skriv sifra pls");
  }

}
if (ageNum >= 18)
{
  Console.Clear();
  Console.WriteLine("Välkommen in!");


int pengar = 100;
int vbucks = 0;
int bannan = 0;
int svärd = 0;
int slutvbucks = 0;
int slutbannan = 0;
int slutsvärd = 0;


while (pengar > 0)
{

  Console.WriteLine($"du har {pengar} pengar kvar");
  Console.WriteLine("vilken vill du köpa? välj 1 , 2 eller 3");
  Console.WriteLine("1 vbucks (2kr)");
  Console.WriteLine("2 bannan (5kr)");
  Console.WriteLine("3 svärd (10kr)");

  string vall = Console.ReadLine().ToLower();
  if (vall == "1")
  {
    Console.WriteLine("hur många vbucks vill du köpa?");

    string antal1 = Console.ReadLine();
    int.TryParse(antal1, out vbucks);


    vbucks *= 2;
    pengar -= vbucks;
    vbucks /= 2;
    slutvbucks += vbucks;


    if (pengar < 0)
    {
      Console.WriteLine("du är ju hemlös typ om du inte har råg , get out of here!");
    }
  }
  if (vall == "2")
  {
    Console.WriteLine("hur många bannaner vill du köpa?");

    string antal2 = Console.ReadLine();
    int.TryParse(antal2, out bannan);


    bannan *= 5;
    pengar -= bannan;
    bannan /= 5;
    slutbannan += bannan;


    if (pengar < 0)
    {
      Console.WriteLine("du är ju hemlös typ om du inte har råg , get out of here!");
    }
  }
  if (vall == "3")
  {
    Console.WriteLine("hur många svärd vill du köpa?");

    string antal3 = Console.ReadLine();
    int.TryParse(antal3, out svärd);


    svärd *= 10;
    pengar -= svärd;
    svärd /= 10;
    slutsvärd += svärd;


    if (pengar < 0)
    {
      Console.WriteLine("du är ju hemlös typ om du inte har råg , get out of here!");
    }
  }
}

Console.Clear();
Console.WriteLine($"DU köpte {slutvbucks} vbucks {slutbannan} bannaner {slutsvärd} svärd");

Console.ReadLine();
}