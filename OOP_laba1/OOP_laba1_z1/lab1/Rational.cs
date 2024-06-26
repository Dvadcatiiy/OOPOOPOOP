﻿using System.Net.Mail;
using System.Runtime.InteropServices;

namespace lab1;

public class Rational
{
    public Rational(int _numerator, int _denominator)
    {
        if (_denominator == 0)
            throw new ArgumentException("The denominator must be non-zero.");

        if (denominator < 0)
        {
            _numerator *= -1;
            _denominator *= -1;
        }

        numerator = _numerator;
        denominator = _denominator;

        ReduceToLowestTerms();
    }

    public int numerator;

    public int Numerator
    {
        get
        {
            return numerator;
        }
        private set
        {
            numerator = value;
        }
    }

    public int denominator;

    public int Denominator
    {
        get
        {
            return denominator;
        }
        private set
        {
            denominator = value;
        }
    }

    private void ReduceToLowestTerms()
    {
        int greatestCommonDivisor = Rational.GetGCD(numerator, denominator);
        numerator /= greatestCommonDivisor;
        denominator /= greatestCommonDivisor;
    }

    private static int GetGCD(int term1, int term2)
    {
        if (term2 == 0)
        {
            return term1;
        }
        else
        {
            return GetGCD(term2, term1 % term2);
        }
    }

    public override string ToString()
    {
        if (numerator % denominator == 0)
        {
            return Convert.ToString(numerator / denominator);
        }
        else if ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0))
        {
            return Convert.ToString($"-{Math.Abs(numerator)} / {Math.Abs(denominator)}");
        }
        else
        {
            return Convert.ToString($"{numerator} / {denominator}");
        }
    }

    public static Rational operator +(Rational obj1, Rational obj2)
    {
        return new Rational((obj1.numerator * obj2.denominator) + (obj2.numerator * obj1.denominator), obj1.denominator * obj2.denominator);
    }

    public static Rational operator -(Rational obj1, Rational obj2)
    {
        return new Rational((obj1.numerator * obj2.denominator) - (obj2.numerator * obj1.denominator), obj1.denominator * obj2.denominator);
    }

    public static Rational operator *(Rational obj1, Rational obj2)
    {
        return new Rational(obj1.numerator * obj2.numerator, obj1.denominator * obj2.denominator);
    }

    public static Rational  operator /(Rational obj1, Rational obj2)
    {
        return new Rational(obj1.numerator * obj2.denominator, obj2.numerator * obj1.denominator);
    }

    public static bool operator ==(Rational obj1, Rational obj2)
    {
        if ((obj1.numerator / (double)obj1.denominator) == (obj2.numerator / (double)obj2.denominator))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator !=(Rational obj1, Rational obj2)
    {
        if ((obj1.numerator / (double)obj1.denominator) != (obj2.numerator / (double)obj2.denominator))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator <(Rational obj1, Rational obj2)
    {
        if ((obj1.numerator / (double)obj1.denominator) < (obj2.numerator / (double)obj2.denominator))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator >(Rational obj1, Rational obj2)
    {
        if ((obj1.numerator / (double)obj1.denominator) > (obj2.numerator / (double)obj2.denominator))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator <=(Rational obj1, Rational obj2)
    {
        if ((obj1.numerator / (double)obj1.denominator) <= (obj2.numerator / (double)obj2.denominator))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator >=(Rational obj1, Rational obj2)
    {
        if ((obj1.numerator / (double)obj1.denominator) >= (obj2.numerator / (double)obj2.denominator))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static Rational operator -(Rational obj1)
    {
        return new Rational(-(obj1.numerator), obj1.denominator);
    }
}