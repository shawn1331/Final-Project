// Shawn Miner Final Project

//smallest multiple of numbers 1 - 20
/*for (int i = 2520; i < 1000000000; i++)
{
    if ( i % 11 ==0 && i % 12 == 0 && i % 13 ==0 && i % 14 ==0 && i % 15 ==0 && i % 16 ==0 && i % 17 ==0 && i % 18 ==0 && i % 19 ==0 && i % 20 ==0 )
    {
        Console.WriteLine(i);
    }
}

// Largest palindrome product
int sum;
int Largest = -1;
string res;
bool Palindrome = true;

for(int i = 999 ; i > 99 ; i--)
{
	for(int j = 999; j > 99 ; j--)
	{
		sum = i * j;
		res = sum.ToString();
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
            if(sum > Largest)
            {
             Largest = sum;
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
Console.WriteLine("The difference of the sum of the squares and the square of the sum is " + difference);*/
