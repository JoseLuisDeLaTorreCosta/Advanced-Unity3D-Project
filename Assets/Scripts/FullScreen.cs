using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullScreen : MonoBehaviour
{
    public bool Fullscreen;

    // Start is called before the first frame update
    void Start()
    {
        ActivarPantallaCompleta(Fullscreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPantallaCompleta (bool pantallaCom)
    {
        Screen.fullScreen = pantallaCom;
        Screen.SetResolution(1280, 720, pantallaCom);
    }
}
