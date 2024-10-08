


while (alder < 18)
{
  Console.WriteLine("du är inte över 18");
}




int pengar = 100;
int vbucks = 0;
//int bannan = 0;
//int svärd = 0;


while (pengar > 0){

    Console.WriteLine($"du har {pengar}");
    Console.WriteLine("vilken vill du köpa? välj 1 , 2 eller 3");
    Console.WriteLine("1 vbucks , det kostar 2kr för 1 vbucks");
    Console.WriteLine("2 bannan , det kostar 5kr for 1 bannan");
    Console.WriteLine("3 svärd , det kostar 10kr för 1 svärd");

    string vall = Console.ReadLine().ToLower();
    if (vall == "vbucks"){
    Console.Clear();

    Console.WriteLine("hur många vbucks vill du köpa?");

  string antal1 = Console.ReadLine();
  


}


Console.ReadLine();
}
Console.ReadLine();
































// int i = 0;
// while(i<10)
// {
//     Console.WriteLine("hej");
//     i++;
// }


// bool success = false;
// int ageNum = 0;

// while (success != true)
// {



//     Console.WriteLine("ålder:");
//     string age = Console.ReadLine();


//     success = int.TryParse(age, out ageNum);

//     if (success == false)
//     {
//         Console.WriteLine("skriv sifra pls");
//     }

// }
//     if (ageNum >= 18)
//     {
//         Console.WriteLine("welcome");

//     }

// Console.ReadLine();