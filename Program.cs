//snack 1

Console.WriteLine("Inserisci il primo numero: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci il secondo numero: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second) Console.WriteLine($"{first} > {second}");
else if (first < second) Console.WriteLine($"{second} > {first}");
else Console.WriteLine($"{first} = {second}");

//snack 2

Console.WriteLine("Inserisci la prima parola: ");
string firstWord = Console.ReadLine();
Console.WriteLine("Inserisci la seconda parola: ");
string secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length) Console.WriteLine($"{firstWord} > {secondWord}");
else if (firstWord.Length < secondWord.Length) Console.WriteLine($"{secondWord} > {firstWord}");
else Console.WriteLine($"{firstWord} = {secondWord}");

//snack 3
int somma = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Inserisci il {i+1}° numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    somma += num;
}

Console.WriteLine($"Somma: {somma}");

//snack 4
int somma2 = 0;
float media = 0;
int n = 0;

for (int i = 2; i <= 10; i++)
{
    somma2 += i;
    n++;
}
media = somma / n;
Console.WriteLine($"Somma: {somma2}");
Console.WriteLine($"Media: {media}");


//snack 5
Console.WriteLine("Inserisci un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

if(numero % 2 == 0)
    Console.WriteLine(numero);
else Console.WriteLine(numero + 1);

//snack 6

string[] invitati = { "Federico", "Luca", "Andrea" };
Console.WriteLine("Inserisci il tuo nome");
string name = Console.ReadLine();
bool flag = false;

foreach (string person in invitati)
{
    if (person == name)
        flag = true;
}

if (flag) Console.WriteLine("Sei invitato!");
else Console.WriteLine("Non sei invitato");

//snack 7
int[] array = new int[5];
int nArr = 0;
int temporary = 0;

for(int i = 0; i < 6; i++)
{
    Console.WriteLine("Inserisci un numero");

    nArr = Convert.ToInt32(Console.ReadLine());
    if (nArr % 2 != 0)
    {
        array[i] = nArr;
        temporary++;
    }
}


//snack 8

int[] arrayNum = { 5, 10, 12, 2, 45, 32, 44 };
int sommaNumeri = 0;

foreach (int i in arrayNum)
{
    if (i % 2 != 0)
        sommaNumeri += i;
}
Console.WriteLine($"Somma numeri: {sommaNumeri}");

//snack 9
sommaNumeri = 0;
int[] arrayWhile = new int[50];
int numSnack9 = 0;
int j = 0;

while (sommaNumeri <= 50)
{
    Console.WriteLine("Inserisci un numero: ");
    numSnack9 = Convert.ToInt32(Console.ReadLine());
    arrayWhile[j] = numSnack9;
    sommaNumeri += numSnack9;
}

//snack 10
Console.WriteLine("Inserisci un numero: ");
int n10 = Convert.ToInt32(Console.ReadLine());
int[] arrayRandom = new int[10];

for(int k = 0; k < n10; k++)
{
    for (int z = 0; z < 10; z++)
    {
        Random rnd = new Random();
        int valueRnd = rnd.Next(1, 100);
        arrayRandom[z] = valueRnd;
    }

    Console.WriteLine($"Array n°{k+1}");
    foreach(int el in arrayRandom)
    {
        Console.WriteLine(el);
    }
}