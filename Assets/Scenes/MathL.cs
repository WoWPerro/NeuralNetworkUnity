using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEngine;

public class MathL : MonoBehaviour
{
    public static double Sigmoid(double x)
    {
        if (x < -45.0) return 0.0;
        else if (x > 45.0) return 1.0;
        else return 1.0 / (1.0 + Math.Exp(-x));
    }

    public static double HyperbolicTangtent(double x)
    {
        return 2 / (1 + Math.Pow(Math.E, -(2 * x))) - 1;
    }

    public static double Derivative(double value)
    {

    }

    public static double SoftMax(double value)
    {

    }

    public static double RELU(double value)
    {

    }

    public static double LeakyRELU(double value)
    {

    }

    public static double Linear(double value)
    {
        return value;
    }
}
