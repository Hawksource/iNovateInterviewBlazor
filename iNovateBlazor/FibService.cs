using System.Numerics;

public class FibService
{
    /*
    If the offsets are negative, this is invalid so uniform array of 1s is returned.
    If the input n is negative, an empty list would be returned because 1 < n is false, so
    the loop is nevr ran.

    This solution can technically handle any whole number input, but the actual max size depends
    on the amount of RAM in your system.
    */
    public BigInteger[] CalcFib(BigInteger input, int offset1=1, int offset2=2)
    {
        if(input<0) return [];
        BigInteger[] ret = new BigInteger[(int)input];
        Array.Fill(ret, 1);
        if(offset1<0||offset2<0) return ret;

        for(BigInteger i = 1;i<=input;i++)
        {
            BigInteger total = 0;
            if(i-1-offset2<0||i-1-offset1<0) continue;
            total+= ret[(int)(i -1-offset1)];
            total+= ret[(int)(i -1-offset2)];
            ret[(int)(i - 1)] = total;
        }
        return ret;
    }
}