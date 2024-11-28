using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class MyComplex : IMyNumber<MyComplex>
{
    double re;
    double im;

    public MyComplex(double re, double im)
    {
        this.re = re;
        this.im = im;
    }

    public MyComplex(MyComplex complex)
    {
        this.re = complex.re;
        this.im = complex.im;
    }

    public MyComplex Add(MyComplex that)
    {
        return new MyComplex(this.re + that.re, this.im + that.im);
    }

    public MyComplex Subtract(MyComplex that)
    {
        return new MyComplex(this.re - that.re, this.im - that.im);
    }

    public MyComplex Multiply(MyComplex that)
    {
        double reNew = this.re * that.re - this.im * that.im;
        double imNew = this.re * that.im + this.im * that.re;
        return new MyComplex(reNew, imNew);
    }       
    public MyComplex Divide(MyComplex that)
    {
        double denom = that.re * that.re + that.im * that.im;
        if (denom == 0)
            throw new DivideByZeroException();

        double rePart = (this.re * that.re + this.im * that.im) / denom;
        double imPart = (this.im * that.re - this.re * that.im) / denom;
        return new MyComplex(rePart, imPart);
    }

    public override string ToString()
    {
        return $"{re} {(im >= 0 ? "+" : "-")} {Math.Abs(im)}i";
    }


}