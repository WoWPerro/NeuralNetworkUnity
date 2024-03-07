using System.Collections.Generic;
using UnityEngine;

public class NeuralNetwork : MonoBehaviour
{
    List<Layer> _layers = new List<Layer>();
    Layer _input;
    Layer _output;

    public Layer input
    {
        get { return _input; }
        set { _input = value; }
    }

    public Layer output
    {
        get { return _output; }
        set { _output = value; }
    }

    public void AddLayer()
    {
        Layer newLayer;
        if (_layers.Count == 0)
        {
            newLayer = new Layer();
            newLayer.prevLayer = _input;
            newLayer.nextLayer = _output;
            _layers.Add(newLayer);
            return;
        }
        Layer lastLayer = _layers[_layers.Count - 1];
        newLayer = new Layer();
        newLayer.prevLayer = lastLayer;
        newLayer.nextLayer = _output;
        lastLayer.nextLayer = newLayer;
    }

    public float GetResult()
    {
        Layer currentLayer = _layers[_layers.Count - 1];
        Layer prevLayer = currentLayer.prevLayer;
        for(int i =0; i < currentLayer.neuron.Length; i++)
        {

        }
        return 0;
    }
}
