using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction();
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int topNumber)
    {
        _numerator = topNumber;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    (
        _numerator = top;
        _denominator = bottom;
    )
}
