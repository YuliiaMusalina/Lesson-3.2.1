int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 100;
int secondDigit = randomNumber / 10;
int thirdDigit = randomNumber % 10;

Console.WriteLine(secondDigit % 10);


int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

