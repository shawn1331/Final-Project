// Shawn Miner Final Project
using static System.Console;
using System.Diagnostics;
string [] answers = new string [9];


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
    WriteLine("9. Highly divisible triangular number.");   
    char choice = ReadKey(true).KeyChar;
    switch (choice)
    {
        case '1':
            Write("Smallest Multiple Of Numbers 1 - 20 is: ");
            SmallestMultiple(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");
        break;

        case '2':
            Write("Largest Palindrome product is: ");
            LargestPalindrome(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");


        break;

        case '3':
            Write("Largest prime factor of 600851475143 is: ");
            LargestPrimeFactor(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '4':
            Write("The difference between the squared sum of the first 100 natural numbers and the sum squared is: ");
            Difference(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '5':
            Write("The 10001st prime number is: ");
            NTHPrime(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '6':
            Write("The largest product in a series is: ");
            Product(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '7':
            Write("Special Pythagorean triplet is: ");
            Triplet(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '8':
            Write("The summation of all primes below 2 million is: ");
            Summation(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");

        break;

        case '9':
            Write("The first triangle number to have over 500 divisors is: ");
            TriangleNumber(ref answers);
            WriteLine("Would you like to return to the main menu? y/n");
        break;
        
        default:
        break;
    }
} while (Console.ReadKey(true).KeyChar == 'y');
File.WriteAllLines("Answers.txt", answers);
WriteLine("Goodbye!");


static int SmallestMultiple (ref string [] answers)
{
    int i;
    for ( i = 2520; i < 232792561; i++)
            {
                if (i % 11 == 0 && i % 12 == 0 && i % 13 == 0 && i % 14 == 0 && i % 15 == 0 && i % 16 == 0 && i % 17 == 0 && i % 18 == 0 && i % 19 == 0 && i % 20 == 0)
                {
                    Console.WriteLine(i);
                    answers[0] = i.ToString();
                }
            }
                    return i;
            
}

static int LargestPalindrome (ref string [] answers)
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
    answers[1] = largest.ToString();
    return largest;
}

static int LargestPrimeFactor (ref string [] answers)
{   
    
    int largest = 5000;
    long number = 600851475143;
    bool isPrime = true;

        for (int i = 3; i <= number; i++)
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
                        answers[2] = largest.ToString();
                        break;
                    }    
                }   
            }
            isPrime = true;
        }
       return largest; 
}

static long Difference(ref string [] answers)
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
    answers [3] = difference.ToString();
    return difference;
}

static int NTHPrime(ref string [] answers)
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
    answers[4] = array[1000].ToString();
    return array[10000];
}

static long Product(ref string [] answers)
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
    answers[5] = biggest.ToString();
    return biggest;
}

static int Triplet (ref string [] answers)
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
answers[6] = total.ToString();
return total;
}

static long Summation(ref string [] answers)
{
    bool isPrime = true;
    long sum = 17;
    for (int i = 11; i < 2000000; i+=2)
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
    answers [7] = sum.ToString();
    return sum;
}

static int TriangleNumber(ref string [] answers)
{
    int nextNumber = 1;
        int triangleNumber = 0;
        while (true)
        {
            int count = 0;
            triangleNumber += nextNumber;
            if (triangleNumber % 6 == 0)
            {
                for (int i = 1; i <= Math.Sqrt(triangleNumber); i++)
                {
                    if (triangleNumber % i == 0)
                    {
                        count++;
                    }
                }
            }
            if (count >= 250)
            {
                break;
            }
            nextNumber++;
        }
        Console.WriteLine(triangleNumber);
        answers [8] = triangleNumber.ToString();
        return triangleNumber;
    
}

static bool IsPrime(int number)
{
 for (int i = number; i <= number; i++)
 {
    if (number <= 1)
    {
        return false;   
    }
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            return false;
        }
    }
 }
 return true;
}
Debug.Assert(IsPrime(7) == true, "7 is a prime number");
Debug.Assert(IsPrime(15) == false, "15 is not a prime number");
Debug.Assert(IsPrime(999) == false, "999 is not a prime number");
Debug.Assert(IsPrime(-10) == false, "-10 is not a prime number");
Debug.Assert(IsPrime(2731) == true, "2731 is a prime number");