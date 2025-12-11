using System.Numerics;

public class FibService
{
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