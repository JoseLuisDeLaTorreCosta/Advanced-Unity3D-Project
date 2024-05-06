using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustCanvas_Controller : MonoBehaviour
{
    Image im;
    Canvas can;
    
    // Start is called before the first frame update
    void Start()
    {
        im = GetComponent<Image>();
        can = GetComponentInParent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
