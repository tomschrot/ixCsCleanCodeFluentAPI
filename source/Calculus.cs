
public sealed class Calculus
{
    //-----------------------------------------------------
    public static Calculus assign (double value = 0) => new Calculus (value);
    //-----------------------------------------------------
    // private field

    private double _value = 0D;

    //-----------------------------------------------------
    // property

    public double value => _value;

    //-----------------------------------------------------
    // constructors

    public Calculus (double value = 0) => setValue (value);

    //-----------------------------------------------------

    public Calculus setValue (double value)
    {
        _value = value;
        return this;
    }
    //-----------------------------------------------------
    // members

    // as property
    public Calculus root   => setValue ( Math.Sqrt (_value) );
    public Calculus square => setValue ( (_value * _value)  );
    public Calculus cubic  => setValue ( (_value * _value * _value)  );

    // as function
    public Calculus add       (double value) => setValue ( _value + value );
    public Calculus substract (double value) => setValue ( _value - value );
    public Calculus multiply  (double value) => setValue ( _value * value );
    public Calculus divide    (double value) => setValue ( _value / value );

    // higher order
    public Calculus operate (Func <double, double> operation)
    =>
        setValue ( operation?.Invoke (_value) ?? double.NaN );

    // higher order, 2 parameters
    public Calculus operate (Func <double, double, double> operation, double value)
    =>
        setValue ( operation?.Invoke (_value, value) ?? double.NaN );

    //-----------------------------------------------------
}
