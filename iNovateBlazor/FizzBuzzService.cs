using System.Numerics;

public class FizzBuzzService
{
    public string CalcFizzBuzz(BigInteger input, int divisor1=3, int divisor2=5, String word1 = "fizz", String word2="buzz")
    {
        string outPut = "";
       if(input%divisor1==0||input%divisor2==0) {
        if(input%divisor1==0) {
            outPut+= word1;
        }

        if(input%divisor2==0) {
            outPut+=word2;
        }
        return outPut;
    }
    return input.ToString();
    }
}