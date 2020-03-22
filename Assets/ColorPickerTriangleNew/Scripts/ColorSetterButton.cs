using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSetterButton : MonoBehaviour
{
    public GameObject ColoringObject;
    private ColorPickerTriangle CP;
    public Text text;

    void Start()
    {
        CP = ColoringObject.GetComponent<ColorPickerTriangle>();
    }

    void Update()
    {
        text.color = CP.TheColor;
    }
}
