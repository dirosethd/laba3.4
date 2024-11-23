double xStart = 0.5;
double xEnd = 2.0;
double h = 0.15;

for (double x = xStart; x <= xEnd; x += h)
{
    double result = CalculateSeries(x);
    Console.WriteLine($"f({x}) = {result}");
}
    
double CalculateSeries(double x)
{
    double sum = 0.0;
    int k = 1;
    double previousTerm = 0.0;

   
    int maxTerms = 100;

    for (k = 1; k <= maxTerms; k++)
    {
       
        double term = (Math.Pow(1.5, k) * Math.Pow(x, k)) / Factorial(2 * k);

        
        if (Math.Abs(term) < 1e-10) break;

        sum += term;
    }

    return sum;
}

double Factorial(int num)
{
    double factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}
