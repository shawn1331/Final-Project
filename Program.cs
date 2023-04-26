// Shawn Miner Final Project

// Smallest Multiple Of Numbers 1 - 20
for (int i = 2520; i < 1000000000; i++)
{
    if ( i % 11 ==0 && i % 12 == 0 && i % 13 ==0 && i % 14 ==0 && i % 15 ==0 && i % 16 ==0 && i % 17 ==0 && i % 18 ==0 && i % 19 ==0 && i % 20 ==0 )
    {
        Console.WriteLine(i);
    }
}

// Largest palindrome product
int sum;
int argest = -1;
string result;
bool Palindrome = true;

for(int i = 999 ; i > 99 ; i--)
{
	for(int j = 999; j > 99 ; j--)
	{
		sum = i * j;
		result = sum.ToString();
		Palindrome = true;
		for(int t = 0;t<res.Length / 2;t++)
		{
			if(res[t] != res[res.Length-t-1]) 
            {
                Palindrome = false;
            }
		}
		if(Palindrome) 
        {
            if(sum > largest)
            {
             largest = sum;
            }
        }    
	}
}
Console.WriteLine(Largest);

// Largest prime factor of 600851475143
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
                    Console.WriteLine(i);
                }
            }
            isPrime = true;

        }

// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum
long difference = 0;
long sumSquared = 0;
long squaredSum = 0;
int i = 1;
long sum = 0;

while (i <= 100)
{
    squaredSum += i * i;
    i++;
}
Console.WriteLine("The sum of the squares of the first 100 natural numbers is " + squaredSum);

for (int j = 1; j <= 100; j++)
{
    sum += j;
}
sumSquared = sum * sum;
Console.WriteLine("The squared sum of the first 100 natural numbers is " + sumSquared );
difference = sumSquared - squaredSum;
Console.WriteLine("The difference of the sum of the squares and the square of the sum is " + difference);

//The 10001st Prime Number

int count = 1;
int start = 3;
int[] array = new int [10001];
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

//Largest Product In A Series
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
        