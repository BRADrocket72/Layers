namespace FactorialService;
public class FactorialServicer
{
    public FactorialServicer(){

    }
    public double calcFactorial(int i)
    {
        if (i == 0 || i == 1)
        {
            return 1;
        }
        return i * calcFactorial(i - 1);
    }
}
