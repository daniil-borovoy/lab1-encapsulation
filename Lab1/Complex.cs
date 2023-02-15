namespace Lab1;

public class Complex
{
    public double Real { get; set; }
    public double Imag { get; set; }

    public void Add(Complex x)
    {
        Real += x.Real;
        Imag += x.Imag;
    }

    public void Substract(Complex x)
    {
        Real -= x.Real;
        Imag -= x.Imag;
    }

    public Complex Multiply(Complex x)
    {
        var real = Real * x.Real - Imag * x.Imag;
        var imag = Real * x.Imag + Imag * x.Real;
        return new Complex() { Real = real, Imag = imag };
    }

    public void Divide(Complex x)
    {
        var denom = x.Real * x.Real + x.Imag * x.Imag;
        Real = (Real * x.Real + Imag * x.Imag) / denom;
        Imag = (Imag * x.Real - Real * x.Imag) / denom;
    }
}