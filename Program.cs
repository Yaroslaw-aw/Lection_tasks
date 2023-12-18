using System.Numerics;

BigInteger Fibonacci(int n)
{
    if (n <= 2) { return 1; }

    BigInteger[] numbers = { 1, 1 };

    BigInteger result = numbers[0] + numbers[1];

    for (int i = 3; i < n; i++)
    {
        if (i % 2 == 0)
            numbers[0] = result;
        else
            numbers[1] = result;

        result = numbers[0] + numbers[1];
    }

    return result;
}

int n = 100_000;

Console.WriteLine($"Fibonacci {n}-й = {Fibonacci(n)}\n");


int CountOfWords(string str)
{
    int result = 0;

    str = str.Trim();

    if (str.Length > 0) { result++; }

    foreach (char c in str)
    {
        if (c == ' ') result++;
    }

    return result;
}

Console.WriteLine(CountOfWords("654 khbt ghjfghfd"));