using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class MathL : MonoBehaviour
{
    public static double Sigmoid(double value)
    {
        float k = (float)Math.Exp(value);
        return k / (1.0f + k);
    }

    public static double HyperbolicTangtent(double value)
    {
        return Math.Tanh(value);
    }

    public static double Derivative(double value)
    {
        return 0;
    }

    public static double[] SoftMax(double[] value)
    {
        double[] softmax = new double[value.Length];
        int i = 0;
        double sum = 0;
        foreach (double v in value)
        {
            softmax[i] = Math.Exp(v);
            sum += softmax[i];
            i++;
        }

        double[] softmax2 = new double[value.Length];
        i = 0;
        foreach (double v in value)
        {
            softmax2[i] = Math.Exp(v) / sum;
            i++;
        }
        return softmax2;
    }

    public static double RELU(double value)
    {
        return (0 >= value) ? 0 : value;
    }

    public static double LeakyRELU(double value)
    {
        return (0 >= value) ? 0.01f * value : value;
    }

    public static double Linear(double value)
    {
        return value;
    }
}
