namespace AverageCalculator;

public class AverageCalculator
{
    private List<double> values;


    public AverageCalculator()
    {
        values = new List<double>();
    }

    public void add(double value)
    {
        values.Add(value);
    }
    public void add(double[] values)
    {
        if (values == null) return;


        foreach (var v in values)
        {
            this.values.Add(v);
        }
    }

    public int count() {
        return values.Count;
    }
}