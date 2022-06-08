public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }



    public long factorial(int n)
    {
        if (n == 1 || n == 0)
            return 1;

        return n * factorial(n - 1);
    }
}

