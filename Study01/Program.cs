namespace Study01;

public class Study01
{
    public static void Main(string[] args)
    {
        Lines lines = new Lines();
        int x = 0;
        if (args.Length == 1 && int.TryParse(args[0], out x))
        {
            Console.WriteLine(lines.MakeAllLines(x));
        }
    }
}
public class Lines
{
    public string MakeALine(int input)
    {
        string output = string.Empty;
        for (int i = 0; i < input; i++)
        {
            output += string.Format("{0} ", input.ToString());
        }
        return output.TrimEnd() + "\r\n";
    }

    public string MakeAllLines(int input)
    {
        string output = string.Empty;
        for (int i = 1; i <= input; i++)
        {
            output += MakeALine(i);
        }
        return output.TrimEnd();
    }
}
