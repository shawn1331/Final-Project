// Shawn Miner Final Project
using static System.Console;

do
{
    WriteLine("Welcome to my final project! Choose between 1 and 9 to select which project euler problem solution you would like to see.");
    WriteLine("1. The Smallest multiple of 1-20.");
    WriteLine("2. Largest palindrome product.");
    WriteLine("3. Largest prime factor of 600851475143.");
    WriteLine("4. Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");
    WriteLine("5. The 10001st Prime Number.");
    WriteLine("6. Largest Product In A Series.");
    WriteLine("7. Special Pythagorean Triplet.");
    WriteLine("8. Sum Of All Primes Below 2 Million. FYI this takes a minute to run!!");
    WriteLine("9. The sum of the digits of 2 to the 1000th power.");   
    char choice = ReadKey(true).KeyChar;
    switch (choice)
    {
        case '1':
            Write("Smallest Multiple Of Numbers 1 - 20 is: ");
            SmallestMultiple();
            WriteLine("Would you like to return to the main menu? y/n");
        break;

        case '2':
            Write("Largest Palindrome product is: ");
            LargestPalindrome();
            WriteLine("Would you like to return to the main menu? y/n");


        break;

        case '3':
            Write("Largest prime factor of 600851475143 is: ");
            LargestPrimeFactor();
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '4':
            Write("The difference between the squared sum of the first 100 natural numbers and the sum squared is: ");
            Difference();
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '5':
            Write("The 10001st prime number is: ");
            NTHPrime();
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '6':
            Write("The largest product in a series is: ");
            Product();
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '7':
            Write("Special Pythagorean triplet is: ");
            Triplet();
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '8':
            Write("The summation of all primes below 2 million is: ");
            Summation();
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '9':
            Write("The sum of the digits of 2 to the 1000th power is: ");
            FactorialDigitSum();
            WriteLine("Would you like to return to the main menu? y/n");
        break;
        
        default:
        break;
    }
} while (Console.ReadKey(true).KeyChar == 'y');
WriteLine("Goodbye!");


static int SmallestMultiple ()
{
    int i;
    for ( i = 2520; i < 232792561; i++)
            {
                if (i % 11 == 0 && i % 12 == 0 && i % 13 == 0 && i % 14 == 0 && i % 15 == 0 && i % 16 == 0 && i % 17 == 0 && i % 18 == 0 && i % 19 == 0 && i % 20 == 0)
                {
                    Console.WriteLine(i);
                }
            }
                    return i;
            
}

static int LargestPalindrome ()
{
    int sum;
    int largest = -1;
    string result;
    bool Palindrome = true;

    for (int i = 999; i > 99; i--)
    {
        for (int j = 999; j > 99; j--)
        {
            sum = i * j;
            result = sum.ToString();
            Palindrome = true;
            for (int t = 0; t < result.Length / 2; t++)
            {
                if (result[t] != result[result.Length - t - 1])
                {
                    Palindrome = false;
                }
            }
            if (Palindrome)
            {
                if (sum > largest)
                {
                    largest = sum;
                }
            }
        }
    }
    Console.WriteLine(largest);
    return largest;
}

static long LargestPrimeFactor ()
{   
    
    long largest = 5000;
    long number = 600851475143;
    bool isPrime = true;

        for (long i = 3; i <= number; i++)
        {
            for (long j = 2; j < i; j++)
            {

                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                if (number % i == 0)
                {
                    if (i > largest)
                    {
                        largest = i;
                        Console.WriteLine(largest);
                        break;
                    }    
                }   
            }
            isPrime = true;
        }
       return largest; 
}

static long Difference()
{
    long difference = 0;
    long sumSquared = 0;
    long squaredSum = 0;
    int i = 1;
    long sum = 0;

    while (i <= 100)
    {
        squaredSum += (i * i);
        i++;
    }
    Console.WriteLine("The sum of the squares of the first 100 natural numbers is " + squaredSum);

    for (int j = 1; j <= 100; j++)
    {
        sum += j;
    }
    sumSquared = sum * sum;
    Console.WriteLine("The squared sum of the first 100 natural numbers is " + sumSquared);
    difference = sumSquared - squaredSum;
    Console.WriteLine("The difference of the sum of the squares and the square of the sum is " + difference);
    return difference;
}

static int NTHPrime()
{
    int count = 1;
    int start = 3;
    int[] array = new int[10001];
    array[0] = 2;

    while (count != 10001)
    {
        bool isPrime = true;

        for (int i = 2; i < start; i++)
        {
            if (start % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            array[count] = start;
            count++;
        }
        start++;
    }
    Console.WriteLine(array[10000]);
    return array[10000];
}

static long Product()
{
    string number = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
    long biggest = 0;
    var length = 13;

    for (int i = 0; i < number.Length - length; i++)
    {
        long total = 1;
        var values = number.Skip(i).Take(length).Select(x => int.Parse(x.ToString())).ToList();

        if (values.Contains(0)) continue;

        foreach (var item in values)
            total *= item;

        if (total > biggest)
            biggest = total;
    }

    Console.WriteLine(biggest);
    return biggest;
}

static int Triplet ()
{
    int total = 1;
for (int a = 1; a <= 1000; a++)
{
    for (int b = 1; b <= 1000; b++)
    {
        for (int c = 1; c <= 1000; c++)
        {
            if ((a*a)+(b*b) == (c*c) && a+b+c == 1000 && a<b && b<c )
            {
                total = a*b*c;
            }
        }
    }
}
Console.WriteLine(total);
return total;
}

static long Summation()
{
    bool isPrime = true;
    long sum = 17;
    for (int i = 11; i < 2000000; i++)
    {
        for (int j = 3; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;   
            }
        }   
            if (isPrime)
            {
                sum += i;
            }
        isPrime = true;
    }
    Console.WriteLine(sum);
    return sum;
}

static long FactorialDigitSum()
{
   long sum = 0; 
   int count = 0; 
   long total = 1;
   long start = 100;
   string number;
   while (start >= 1)
   {
        start *= total;
        start--;
   }
   number = start.ToString();
   while (count < number.Length)
   {
        sum += number[count];
   }
   Write(sum);
   return sum;
}