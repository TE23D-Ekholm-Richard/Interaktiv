Console.WriteLine("Användarnamn: ");
string name = Console.ReadLine();

if (name == "Richard")
{
    Console.WriteLine("Välkommen, du är fast i en toalett, du känner din kropp sjunka och du måste göra någonting snabbt.");
    Console.WriteLine("1. Du blir ett med toaletten.");
    Console.WriteLine("2. Du blir vän med toaltten👅.");
    string val_1 = Console.ReadLine();
    if (val_1 == "1") {
        Console.WriteLine("Du blir jagad av camera mans och exploderar och dör bozo");
    }
    if(val_1 == "2") {
        Console.WriteLine("Ni stirrar varandra i ögonen och skakar hand");
        Console.WriteLine("1. Du går på ett äventyr och erat mål är att uttrota Mario🤣");
        Console.WriteLine("2. Ni försöker hitta inner peace och söker buddha🙏");
        string val_2 = Console.ReadLine();
        if(val_2 == "1") {
            Console.WriteLine("Mario ber om nåd innan Bowser kommer och slurkar upp er!");
        }
        if(val_2 == "2"){
            Console.WriteLine("Ni följer Buddhas väg och är nära på att uppnå inner peace");
            
        }
        

    }
    
}
else
{
    Console.WriteLine("Fel användarnamn...");

}
 


Console.ReadLine();