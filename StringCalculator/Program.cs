public class StringCalculator
{
    public static int Calculate(string arg)
    {
        //if (arg.Length == 0)
        //    return 0;
        int arg1, res=0;
        string[] temp = arg.Split(',', StringSplitOptions.RemoveEmptyEntries);
        foreach(string s in temp)
        {
            if (Int32.TryParse(s, out arg1))
                res += arg1;
        }
        return res;
    }
    public static void Main()
    {

    }
}