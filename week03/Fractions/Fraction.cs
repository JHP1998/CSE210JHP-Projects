using System;

public class Fraction
{
    private int_top;
    private int_bottom;
    

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
     return (double)_top /(double)_bottom;
        
}