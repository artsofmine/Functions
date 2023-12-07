// Total < 10 - 1%
// Total >= 10 && < 20 - 5%
// Total >= 20 - 10%

Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your dicount is: {discount}%");

// double newTotal = userInput - (userInput * discount) / 100; - viidud funktsiooni

double newTotal = CalculateNewTotal(userInput, discount); // funktsiooniga

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total) // double(andmete tüüp) tähendab et andmed salvestatakse vahemällu et neid saaks uuesti kasutada
{
    if (total < 10)
    {
        return 1; 
    }
    else if (total >= 10 && total < 20) 
    {
        return 5;
    }
    else
    {
        return 10; 
    }
}
// vastav return salvestatakse vahemällu, et sellega hiljem tehingut teha

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}