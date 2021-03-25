public class Xbonacci
{
    public double[] Tribonacci(double[] signature, int n)
    {
        // hackonacci me
        double[] tribonacci = new double[n];

        if (n == 0)
        {
            return tribonacci;
        }
        if (n < 4)
        {
            for (int i = 0; i < tribonacci.Length; i++)
            {
                tribonacci[i] = signature[i];
                return tribonacci;
            }
        }
        for (int i = 0; i < signature.Length; i++)
        {
            tribonacci[i] = signature[i];
        }
        for (int i = 3; i < tribonacci.Length; i++)
        {
            tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
        }
        return tribonacci;
    }
}