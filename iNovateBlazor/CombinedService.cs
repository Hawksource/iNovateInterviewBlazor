using System.Numerics;

public class CombinedService(FibService fibService, FizzBuzzService fizzBuzzService)
{
    private readonly FibService _fibService = fibService;
    private readonly FizzBuzzService _fizzService = fizzBuzzService;

    /*
    input is safe: if < 1, an empty list is returned. Safety for the other arguments depends on the functions they are passed to.
    */
    public string[] CalcCombined(BigInteger input, int offset1=1, int offset2=2, int div1=3, int div2=5, string word1="fizz", string word2="buzz")
    {
        if(input < 1)
        {
            return [];
        }
        BigInteger[] fib = _fibService.CalcFib(input, offset1,offset2);
        string[] output = new string[(int)input];

        for(BigInteger i = 1;i<=input;i++)
        {
            output[(int)(i - 1)] = _fizzService.CalcFizzBuzz(fib[(int)i - 1],div1,div2,word1,word2);
        }
        return output;
    }
}