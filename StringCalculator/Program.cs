public class StringCalculator
{
    public static int Calculate(string arg)
    {
        //if (arg.Length == 0)
        //    return 0;
        int arg1, res=0;
        if (Int32.TryParse(arg, out arg1))
            res += arg1;
        return res;
    }
    public static void Main()
    {

    }
}