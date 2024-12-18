using System.Runtime.Serialization.Formatters;

Random rnd = new Random();


int MyRandomNum;

int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    MyRandomNum = rnd.Next(0, 11); //0-10
    randomSum = randomSum + MyRandomNum;
    Console.WriteLine($"My random number is: {MyRandomNum}");
}
Console.WriteLine($"random sum total: {randomSum}");