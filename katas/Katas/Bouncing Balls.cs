public class BouncingBall
{

    public static int bouncingBall(double h, double bounce, double window)
    {
        if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
        {
            return -1;
        }

        int num = 1;

        while (h * bounce > window)
        {
            h = h * bounce;
            num += 2;
        }

        return num;
    }
}