using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Controller : MonoBehaviour
{
    public float MaxValue;
    public float MinValue;

    Slider s;
    
    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<Slider>();
        s.maxValue = MaxValue;
        s.minValue = MinValue;
        maxSlider();
    }

    public void maxSlider()
    {
        s.value = s.maxValue;
    }

    public void minSlider() 
    { 
        s.value = s.minValue; 
    }

    public void increaseSlider(float value)
    {
        s.value += value;
        if (s.value > s.maxValue) maxSlider();
    }

    public void decreaseSlider(float value)
    {
        s.value -= value;
        if (s.value < s.minValue) minSlider();
    }

    public void SetSlider(float value)
    {
        s.value = value;
        if (s.value > s.maxValue) maxSlider();
        else if (s.value < s.minValue) minSlider();
    }
}
