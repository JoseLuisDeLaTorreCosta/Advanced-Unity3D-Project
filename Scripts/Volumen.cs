using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider Control_vol;
    public float volumen;

    // Start is called before the first frame update
    void Start()
    {
        Control_vol.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = Control_vol.value;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSlider(float valor)
    {
        volumen = valor;
        PlayerPrefs.SetFloat("volumenAudio", volumen);
        AudioListener.volume = Control_vol.value;
    }
}
