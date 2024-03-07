using UnityEngine;

public class Layer : MonoBehaviour
{
    Neuron[] _neurons;
    float[] _weights;
    float[] _bias;
    Activation _activation;
    Layer _prevLayer;
    Layer _nextLayer;

    public Neuron[] neuron
    {
        get { return _neurons; }
        set { _neurons = value; }
    }

    public float[] weights
    {
        get { return _weights; }
        set { _weights = value; }
    }

    public float[] bias
    {
        get { return _bias; }
        set { _bias = value; }
    }

    public Layer prevLayer
    {
        get { return _prevLayer; }
        set { _prevLayer = value; }
    }

    public Layer nextLayer
    {
        get { return _nextLayer; }
        set { _nextLayer = value; }
    }

    public void SetActivation(Activation t_activation)
    {
        if (_activation == t_activation)
        {
            return;
        }
        _activation = t_activation;
    }
}
