using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Text_bullets : MonoBehaviour
{
    int bullets = 10;
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

    void UpdateText()
    {
        text.text = "" + bullets;
    }

    public void increaseBullets(int value) {
        bullets += value;
        UpdateText();
    }

    public void decreaseBullets(int value)
    {
        --bullets;
        UpdateText();
    }

    public void SetBullets(int value)
    {
        bullets = value;
        UpdateText();
    }
}
