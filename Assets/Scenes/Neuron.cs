using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Activation { ReLU, LeakyReLU, Softmax, Sigmoid, Linear, HyperbolicTangent, Derivative }

public class Neuron : MonoBehaviour
{
    float _value;
    float[] _input;
    float _output;

    //MathL _activation;

    public float value{
        get { return _value; }
        set { _value = value; }
    }

    public float[] input { 
        get { return _input; } 
        set { _input = value; } 
    }

    public float output { 
        get { return _output; } 
        set {  _output = value; } 
    }

    //public MathL activation { 
    //    get { return _activation; }
    //    set { _activation = value; }
    //}
}
