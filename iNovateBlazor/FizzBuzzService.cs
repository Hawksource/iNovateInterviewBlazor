using System.Numerics;

public class FizzBuzzService
{
    /*
    the inputs for CalcFizzBuzz are input safe, i.e. for divisor1 and 2, it does not matter if it is 0 or negative,
    as n % m == n % -m and if m were 0, there is a check for it, so simply n would be returned.

    Input could be negative, but that also does not matter in this case because even though -n % m != n % m, this function is
    used in connection with a for loop that goes from 1 --> input, so if input < 1, the loop doesnt even get ran.
    */
    public string CalcFizzBuzz(BigInteger input, int divisor1=3, int divisor2=5, String word1 = "fizz", String word2="buzz")
    {
        string outPut = "";
        bool skipDiv1 = false;
        bool skipDiv2 = false;
        if(divisor1 == 0) skipDiv1 = true;
        if(divisor2 == 0) skipDiv2 = true;
       if((!skipDiv1&&input%divisor1==0)||(!skipDiv2&&input%divisor2==0)) {
        if(!skipDiv1&&input%divisor1==0) {
            outPut+= word1;
        }

        if(!skipDiv2&&input%divisor2==0) {
            outPut+=word2;
        }
        return outPut;
    }
    return input.ToString();
    }
}