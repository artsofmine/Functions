Console.WriteLine("Are you coming or leaving? (in/out)");
string UserChioce = Console.ReadLine();

if (UserChioce == "in")
{
    PrintHello(); // funktsiooni välja kutsumine
}
else
{
    PrintGoodBye();
}

static void PrintHello() // void tähendanab tühmikku ehk vahemällu ei jää midagi
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later!");
}

//static on funktsiooni tüüp,iseseisev, mida saab välja kutsuda ilma objektita (console.ReadLine, Console.WriteLine)